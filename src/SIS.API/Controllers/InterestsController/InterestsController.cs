using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        private readonly IinterestsManager _manager;

        public InterestsController(IMapper mapper, IinterestsManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> PostInterests(InterestsCreateRequest request)
        {
            var dto = _mapper.Map<InterestsCreateDTO>(request);

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            dto.UserId = identityClaimNum;

            await _manager.CreateInterests(dto);

            return Ok();
        }
    } 
}