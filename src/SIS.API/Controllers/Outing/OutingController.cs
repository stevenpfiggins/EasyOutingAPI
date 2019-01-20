using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Outing;
using RedStarter.Business.DataContract.Outing.DTOs;
using RedStarter.Business.DataContract.Outing.Interfaces;

namespace RedStarter.API.Controllers.Outing
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutingController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOutingManager _manager;

        public OutingController(IMapper mapper, IOutingManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        //[Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> PostOuting(OutingCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<OutingCreateDTO>(request);
            dto.CreatedBy = User.Identity.Name;
            dto.CreatedOn = DateTime.Now;
            dto.OwnerId = GetUser();

            if (await _manager.CreateOuting(dto))
                return StatusCode(201);

            throw new Exception();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetOutings()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetOutings();
            var response = _mapper.Map<IEnumerable<OutingGetListItemResponse>>(dto);

            return Ok(response);
        }

        [HttpGet]
        [Route("Feed")]
        public async Task<IActionResult> GetOutingsByUserLocation()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var userId = GetUser();
            var dto = await _manager.GetOutingsByInterestsLocation(userId);
            var response = _mapper.Map<IEnumerable<OutingGetListItemResponse>>(dto);
            return Ok(response);
        }

        [HttpGet]
        [Authorize(Roles ="Admin, User")]
        [Route("MyOutings")]
        public async Task<IActionResult> GetOutingsByUser()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var userId = GetUser();
            var dto = await _manager.GetOutingsByUser(userId);
            var response = _mapper.Map<IEnumerable<OutingGetListItemResponse>>(dto);

            return Ok(response);
        }
        
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOutingById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetOutingById(id);
            var response = _mapper.Map<OutingGetByIdRequest>(dto);

            return Ok(response);
        }

        [HttpPut]
        //[Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> OutingUpdate(OutingUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<OutingUpdateDTO>(request);
            dto.OwnerId = GetUser();
            dto.CreatedOn = DateTimeOffset.Now;

            if (await _manager.OutingUpdate(dto))
            {
                return StatusCode(201);
            }
            throw new Exception();

        }

        [HttpDelete("{id}")]
        //[Authorize(Roles ="Admin, User")]
        public async Task<IActionResult> DeleteOuting(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            if (await _manager.DeleteOuting(id))
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