using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Interests;
using RedStarter.Business.DataContract.Interests;

namespace RedStarter.API.Controllers.InterestsController
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : Controller
    {
        private readonly IMapper _mapper;

        public InterestsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostInterests(InterestsCreateRequest request)
        {
            var dto = _mapper.Map<InterestsCreateDTO>(request);

            return Ok();
        }
    } 
}