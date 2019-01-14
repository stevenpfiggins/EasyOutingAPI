using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

            await _context.OutingTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteOuting(int id)
        {
            var query = await _context.OutingTableAccess.SingleAsync(q => q.OutingEntityId == id);
            _context.OutingTableAccess.Remove(query);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<OutingGetListItemRAO>> GetOutings()
        {
            var query = await _context.OutingTableAccess.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<OutingGetListItemRAO>>(query);

            return rao;
        }

        public async Task<OutingGetListItemRAO> GetOutingById(int id)
        {
            var query = await _context.OutingTableAccess.SingleAsync(q => q.OutingEntityId == id);
            var rao = _mapper.Map<OutingGetListItemRAO>(query);

            return rao;
        }

        public async Task<bool> OutingUpdate(OutingUpdateRAO rao)
        {
            var entity = await _context
                .OutingTableAccess
                .SingleOrDefaultAsync(e => e.OwnerId == rao.OwnerId);

            entity.OutingDate = rao.OutingDate;
            entity.OutingDescription = rao.OutingDescription;
            entity.OutingName = rao.OutingName;


            return await _context.SaveChangesAsync() == 1;
        }
    }
}
