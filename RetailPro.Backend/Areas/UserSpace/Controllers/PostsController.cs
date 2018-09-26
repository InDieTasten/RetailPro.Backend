using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailPro.Backend.Areas.UserSpace.Models;
using RetailPro.Backend.Areas.UserSpace.Models.Posts;

namespace RetailPro.Backend.Areas.UserSpace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // GET: api/posts
        [HttpGet]
        public IEnumerable<PostDto> Get()
        {
            return new PostDto[] { new PostDto(), new PostDto() };
        }

        // GET: api/posts/5
        [HttpGet("{id}", Name = "Get")]
        public PostDto Get(Guid id)
        {
            return new PostDto();
        }

        // POST: api/Posts
        [HttpPost]
        public void Post([FromBody] PublishPostDto value)
        {
        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] PublishPostDto value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
