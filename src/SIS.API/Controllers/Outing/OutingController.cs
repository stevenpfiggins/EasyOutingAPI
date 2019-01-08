using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Outing;

namespace RedStarter.API.Controllers.Outing
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class OutingController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> PostOuting(OutingCreateRequest request)
        {
            return Ok();
        }
    }
}