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

        public Task<bool> ChangeIntToEnum(int outingType)
        {
            throw new NotImplementedException();
        }

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
    }
}
