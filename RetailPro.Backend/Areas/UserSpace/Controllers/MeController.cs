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
    public class MeController : ControllerBase
    {
        // GET: api/Me
        [HttpGet]
        public MeDto Get()
        {
            return new MeDto();
        }

        // PUT: api/Me
        [HttpPut]
        public void Put([FromBody] MeDto value)
        {
        }
    }
}
