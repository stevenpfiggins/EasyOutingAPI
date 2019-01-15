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
        private readonly IInterestsManager _manager;

        public InterestsController(IMapper mapper, IInterestsManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> PostInterests(InterestsCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }
            var dto = _mapper.Map<InterestsCreateDTO>(request);

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            dto.OwnerId = identityClaimNum;

            if (await _manager.CreateInterests(dto))
                return StatusCode(201);
            throw new Exception();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetInterests(int id)
        {
            if (!ModelState.IsValid)

            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetInterests(id);
            var response = _mapper.Map<InterestsResponse>(dto);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> DeleteInterests(int id)
        {
            if (await _manager.DeleteInterests(id))
                return StatusCode(201);
            throw new Exception();

        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> InterestsUpdate(InterestsUpdateItem request)
        {

            if (!ModelState.IsValid)

            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<InterestsUpdateDTO>(request);
            if (await _manager.UpdateInterests(dto))
            {
                return StatusCode(201);
            }

            throw new Exception();

        }
    } 

}