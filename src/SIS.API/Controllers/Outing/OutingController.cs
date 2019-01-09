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
        public async Task<IActionResult> PostOuting(OutingCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = _mapper.Map<OutingCreateDTO>(request);
            dto.CreatedOn = DateTime.Now;
            dto.OwnerId = identityClaimNum;
            switch (request.OutingType)
            {
                case 1:
                    dto.OutingType = OutingType.Canoeing;
                    break;
                case 2:
                    dto.OutingType = OutingType.Kayaking;
                    break;
                case 3:
                    dto.OutingType = OutingType.Hiking;
                    break;
                case 4:
                    dto.OutingType = OutingType.RockClimbing;
                    break;
                case 5:
                    dto.OutingType = OutingType.Camping;
                    break;
                case 6:
                    dto.OutingType = OutingType.Fishing;
                    break;
                case 7:
                    dto.OutingType = OutingType.SightSeeing;
                    break;
                case 8:
                    dto.OutingType = OutingType.Football;
                    break;
                case 9:
                    dto.OutingType = OutingType.Basketball;
                    break;
                case 10:
                    dto.OutingType = OutingType.Soccer;
                    break;
                case 11:
                    dto.OutingType = OutingType.Baseball;
                    break;
                case 12:
                    dto.OutingType = OutingType.Hockey;
                    break;
                case 13:
                    dto.OutingType = OutingType.Tennis;
                    break;
                case 14:
                    dto.OutingType = OutingType.Golf;
                    break;
                case 15:
                    dto.OutingType = OutingType.Running;
                    break;
                case 16:
                    dto.OutingType = OutingType.WeightLifting;
                    break;
                case 17:
                    dto.OutingType = OutingType.Yoga;
                    break;
                case 18:
                    dto.OutingType = OutingType.Gymnastics;
                    break;
                case 19:
                    dto.OutingType = OutingType.Restaurants;
                    break;
                case 20:
                    dto.OutingType = OutingType.Bars;
                    break;
                case 21:
                    dto.OutingType = OutingType.Wineries;
                    break;
                case 22:
                    dto.OutingType = OutingType.Consoles;
                    break;
                case 23:
                    dto.OutingType = OutingType.BoardGames;
                    break;
                case 24:
                    dto.OutingType = OutingType.CardGames;
                    break;
                case 25:
                    dto.OutingType = OutingType.Arcades;
                    break;
                case 26:
                    dto.OutingType = OutingType.Movies;
                    break;
                case 27:
                    dto.OutingType = OutingType.Theatre;
                    break;
                case 28:
                    dto.OutingType = OutingType.Concerts;
                    break;
                case 29:
                    dto.OutingType = OutingType.Festivals;
                    break;
                case 30:
                    dto.OutingType = OutingType.Clubs;
                    break;
                case 31:
                    dto.OutingType = OutingType.Bowling;
                    break;
                case 32:
                    dto.OutingType = OutingType.Zoo;
                    break;
                case 33:
                    dto.OutingType = OutingType.Painting;
                    break;
                case 34:
                    dto.OutingType = OutingType.Knitting;
                    break;
                case 35:
                    dto.OutingType = OutingType.Pottery;
                    break;
                case 36:
                    dto.OutingType = OutingType.Museums;
                    break;
                case 37:
                    dto.OutingType = OutingType.Aquariums;
                    break;
                case 38:
                    dto.OutingType = OutingType.Galleries;
                    break;
            }

            if (await _manager.CreateOuting(dto))
                return StatusCode(201);

            throw new Exception();
        }
    }
}