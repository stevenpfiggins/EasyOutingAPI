﻿using AutoMapper;
using RedStarter.Business.DataContract.Interests;
using RedStarter.Database.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Interests
{
    public class InterestsManager : IInterestsManager
    {
        private readonly IMapper _mapper;
        private readonly IInterestsRepository _repository;

        public InterestsManager(IMapper mapper, IInterestsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public async Task<bool> CreateInterests(InterestsCreateDTO dto)
        {
            var rao = _mapper.Map<InterestsCreateRAO>(dto);

            if (await _repository.CreateInterests(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<InterestsGetListItemDTO>> GetInterests()
        {
            var rao = await _repository.GetInterests();
            var dto = _mapper.Map<IEnumerable<InterestsGetListItemDTO>>(rao);

            return dto;
        }

        public async Task<IEnumerable<InterestsGetListItemDTO>> GetInterestsByUser(int id)
        {
            var rao = await _repository.GetInterestsByUser(id);
            var dto = _mapper.Map<IEnumerable<InterestsGetListItemDTO>>(rao);

            return dto;
        }


        public async Task<InterestsGetByIdDTO> GetInterestsByOwnerId(int id)
        {
            var rao = await _repository.GetInterestsByOwnerId(id);
            var dto = _mapper.Map<InterestsGetByIdDTO>(rao);

            return dto;
        }

        public async Task<InterestsGetByIdDTO> GetInterestsByEntityId(int id)
        {
            var rao = await _repository.GetInterestsByEntityId(id);
            var dto = _mapper.Map<InterestsGetByIdDTO>(rao);

            return dto;
        }

        public async Task<bool> DeleteInterests(int id)
        {
           if  (await _repository.DeleteInterests(id))
            return true;
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateInterests(InterestsUpdateDTO dto)
        {
            var rao = _mapper.Map<InterestsUpdateRAO>(dto);

            if (await _repository.UpdateInterests(rao))
            {
                return true;

            }
            return false;
        }
    }
}
