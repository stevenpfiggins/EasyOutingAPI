using AutoMapper;
using RedStarter.API.DataContract.Outing;
using RedStarter.Business.DataContract.Outing.DTOs;
using RedStarter.Database.DataContract.Outing.RAOs;
using RedStarter.Database.Entities.Outing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class OutingMappingProfile : Profile
    {
        public OutingMappingProfile()
        {
            CreateMap<OutingCreateRequest, OutingCreateDTO>();
            CreateMap<OutingCreateDTO, OutingCreateRAO>();
            CreateMap<OutingCreateRAO, OutingEntity>();

            CreateMap<OutingEntity, OutingGetListItemRAO>();
            CreateMap<OutingGetListItemRAO, OutingGetListItemDTO>();
            CreateMap<OutingGetListItemDTO, OutingGetListItemResponse>();
        }
    }
}
