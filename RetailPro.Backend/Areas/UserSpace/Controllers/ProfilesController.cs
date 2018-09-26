using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailPro.Backend.Areas.UserSpace.Models;

namespace RetailPro.Backend.Areas.UserSpace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        // GET: api/profiles
        [HttpGet]
        public IEnumerable<PublicProfileDto> Get()
        {
            return new PublicProfileDto[] { new PublicProfileDto(), new PublicProfileDto() };
        }

        // GET: api/profiles/5
        [HttpGet("{id}", Name = "Get")]
        public PublicProfileDto Get(Guid id)
        {
            return new PublicProfileDto();
        }
    }
}
