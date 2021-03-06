﻿using AutoMapper;
using RedStarter.API.DataContract.Interests;
using RedStarter.Business.DataContract.Interests;
using RedStarter.Database.DataContract.Interests;
using RedStarter.Database.Entities.Interests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class InterestsMappingProfile : Profile
    {
        public InterestsMappingProfile()
        {
            CreateMap<InterestsCreateRequest, InterestsCreateDTO>();
            CreateMap<InterestsCreateDTO, InterestsCreateRAO>();
            CreateMap<InterestsCreateRAO, InterestsEntity>();

            CreateMap<InterestsEntity, InterestsGetListItemRAO>();
            CreateMap<InterestsGetListItemRAO, InterestsGetListItemDTO>();
            CreateMap<InterestsGetListItemDTO, InterestsResponse>();

            CreateMap<InterestsEntity, InterestsGetByIdRAO>();
            CreateMap<InterestsGetByIdRAO, InterestsGetByIdDTO>();
            CreateMap<InterestsGetByIdDTO, InterestsGetByIdRequest>();

            CreateMap<InterestsUpdateItem, InterestsUpdateDTO>();
            CreateMap<InterestsUpdateDTO, InterestsUpdateRAO>();
            CreateMap<InterestsUpdateRAO, InterestsEntity>();
        }
    }
}
