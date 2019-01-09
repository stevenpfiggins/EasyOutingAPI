using AutoMapper;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Outing.Interfaces;
using RedStarter.Database.DataContract.Outing.RAOs;
using RedStarter.Database.Entities.Outing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Outing
{
    public class OutingRepository : IOutingRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public OutingRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateOuting(OutingCreateRAO rao)
        {
            var entity = _mapper.Map<OutingEntity>(rao);

            _context.OutingTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;

            throw new NotImplementedException();
        }
    }
}
