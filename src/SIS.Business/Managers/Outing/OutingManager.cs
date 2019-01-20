using AutoMapper;
using RedStarter.Business.DataContract.Outing.DTOs;
using RedStarter.Business.DataContract.Outing.Interfaces;
using RedStarter.Database.DataContract.Interests;
using RedStarter.Database.DataContract.Outing.Interfaces;
using RedStarter.Database.DataContract.Outing.RAOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Outing
{
    public class OutingManager : IOutingManager
    {
        private readonly IMapper _mapper;
        private readonly IOutingRepository _outingRepository;
        private readonly IInterestsRepository _interestsRepository;

        public OutingManager(IMapper mapper, IOutingRepository outingRepository, IInterestsRepository interestsRepository)
        {
            _mapper = mapper;
            _outingRepository = outingRepository;
            _interestsRepository = interestsRepository;
        }

        public async Task<bool> CreateOuting(OutingCreateDTO dto)
        {
            var rao = _mapper.Map<OutingCreateRAO>(dto);

            if (await _outingRepository.CreateOuting(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OutingGetListItemDTO>> GetOutings()
        {
            var rao = await _outingRepository.GetOutings();
            var dto = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(rao);

            return dto;
        }

        public async Task<IEnumerable<OutingGetListItemDTO>> GetOutingsByInterestsLocation(int id)
        {
            var rao = await _outingRepository.GetOutings();
            var interestsRao = await _interestsRepository.GetInterestsByOwnerId(id);

            var collectionOfMatchedLocations = new List<OutingGetListItemRAO>();
            foreach (var item in rao)
            {
                if (item.OutingLocation == interestsRao.UserLocation)
                {
                    collectionOfMatchedLocations.Add(item);
                }
            }

            var matchedList = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(collectionOfMatchedLocations);
            
            return matchedList;
        }

        public async Task<IEnumerable<OutingGetListItemDTO>> GetOutingsByUser(int id)
        {
            var rao = await _outingRepository.GetOutingsByUser(id);
            var dto = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(rao);

            return dto;
        }

        public async Task<OutingGetByIdDTO> GetOutingById(int id)
        {
            var rao = await _outingRepository.GetOutingById(id);
            var dto = _mapper.Map<OutingGetByIdDTO>(rao);

            return dto;
        }

        public async Task<bool> OutingUpdate(OutingUpdateDTO dto)
        {
            var rao = _mapper.Map<OutingUpdateRAO>(dto);

            if (await _outingRepository.OutingUpdate(rao))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteOuting(int id)
        {
            if (await _outingRepository.DeleteOuting(id))
                return true;
            throw new NotImplementedException();
        }

    }
}
