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
            var identityClaimNum = GetUser();

            dto.UserName = User.Identity.Name;
            dto.OwnerId = identityClaimNum;

            if (await _manager.CreateInterests(dto))
                return StatusCode(201);

            throw new Exception();
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetInterests()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetInterests();
            var response = _mapper.Map<IEnumerable<InterestsResponse>>(dto);

            return Ok(response);
        }

        [HttpGet]
        [Authorize(Roles ="Admin, User")]
        [Route("MyInterests")]
        public async Task<IActionResult> GetInterestsByUser()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var userId = GetUser();
            var dto = await _manager.GetInterestsByUser(userId);
            var response = _mapper.Map<IEnumerable<InterestsResponse>>(dto);

            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> GetInterestsByOwnerId(int id)
        {
            if (!ModelState.IsValid)

            {
                return StatusCode(400);
            }

            var dto = await _manager.GetInterestsByOwnerId(id);
            var response = _mapper.Map<InterestsGetByIdRequest>(dto);

            return Ok(response);
        }

        [HttpGet]
        [Route("InterestsProfile/{id}")]
        public async Task<IActionResult> GetInterestsByEntityId(int id)
        {
            if (!ModelState.IsValid)

            {
                return StatusCode(400);
            }

            var dto = await _manager.GetInterestsByEntityId(id);
            var response = _mapper.Map<InterestsGetByIdRequest>(dto);

            return Ok(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin, User")]
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

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteInterests(int id)
        {
            if (await _manager.DeleteInterests(id))
                return StatusCode(204);

            throw new Exception();

        }

        private int GetUser()
        {
            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return identityClaimNum;
        }
    } 

}