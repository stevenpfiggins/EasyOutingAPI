using AutoMapper;
using RedStarter.Business.DataContract.Interests;
using RedStarter.Database.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Interests
{
    public class InterestsManager : IinterestsManager
    {
        private readonly IMapper _mapper;
        private readonly IinterestsRepository _repository;

        public InterestsManager(IMapper mapper, IinterestsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public async Task<bool> CreateInterests(InterestsCreateDTO dto)
        {
            var rao = _mapper.Map<InterestsCreateRAO>(dto);

            await _repository.CreateInterests(rao);

            throw new NotImplementedException();
        }
    }
}
