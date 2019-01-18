using AutoMapper;
using RedStarter.Business.DataContract.Outing.DTOs;
using RedStarter.Business.DataContract.Outing.Interfaces;
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
        private readonly IOutingRepository _repository;

        public OutingManager(IMapper mapper, IOutingRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreateOuting(OutingCreateDTO dto)
        {
            var rao = _mapper.Map<OutingCreateRAO>(dto);

            if (await _repository.CreateOuting(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OutingGetListItemDTO>> GetOutings()
        {
            var rao = await _repository.GetOutings();
            var dto = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(rao);

            return dto;
        }

        public async Task<IEnumerable<OutingGetListItemDTO>> GetOutingsByUser(int id)
        {
            var rao = await _repository.GetOutingsByUser(id);
            var dto = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(rao);

            return dto;
        }

        public async Task<OutingGetByIdDTO> GetOutingById(int id)
        {
            var rao = await _repository.GetOutingById(id);
            var dto = _mapper.Map<OutingGetByIdDTO>(rao);

            return dto;
        }

        public async Task<bool> OutingUpdate(OutingUpdateDTO dto)
        {
            var rao = _mapper.Map<OutingUpdateRAO>(dto);

            if (await _repository.OutingUpdate(rao))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteOuting(int id)
        {
            if (await _repository.DeleteOuting(id))
                return true;
            throw new NotImplementedException();
        }

    }
}
