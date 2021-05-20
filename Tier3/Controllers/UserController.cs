using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TierOne;
using Tier3.Services;

namespace Tier3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private IUserServices services;

        public UserController(IUserServices services)
        {
            this.services = services;
        }
        
        [HttpGet]
        public async Task<ActionResult<User>> GetUser()
        {
            try
            {
                User tempUser = await services.GetRandomUser();
                return Ok(tempUser);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}