using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetailPro.Backend.Areas.UserSpace.DbContexts;
using RetailPro.Backend.Areas.UserSpace.Models;
using System;
using System.Threading.Tasks;

namespace RetailPro.Backend.Areas.UserSpace.Controllers
{
    [ApiExplorerSettings(IgnoreApi = false)]
    [Route("odata/[controller]")]
    public class UsersController : ODataController
    {
        private readonly UserDbContext _context;

        public UsersController(UserDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> Get() => Ok(await _context.Users.AsNoTracking().ToListAsync());

        //[HttpGet]
        //[EnableQuery]
        //public async Task<IActionResult> Get(Guid key)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    User user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == key);

        //    return user == null ? NotFound() : (IActionResult)Ok(user);
        //}

        [HttpPut]
        [EnableQuery]
        public async Task<IActionResult> Put(Guid key, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (key != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        [EnableQuery]
        public async Task<IActionResult> Post(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        [HttpDelete]
        [EnableQuery]
        public async Task<IActionResult> Delete(Guid key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User user = await _context.Users.FindAsync(key);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        private async Task<bool> UserExists(Guid id) => await _context.Users.AsNoTracking().AnyAsync(e => e.Id == id);
    }
}