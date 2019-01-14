using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedStarter.API.DataContract.Interests;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Interests;
using RedStarter.Database.Entities.Interests;
using RedStarter.Database.Entities.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Interests
{
    public class InterestsRepository : IInterestsRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<UserEntity> _userManager;

        public InterestsRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateInterests(InterestsCreateRAO rao)
        {
            foreach (int Interest in rao.Interests)
            {
                var entity = new InterestsEntity()
                {
                    OwnerId = rao.UserId,
                    Interests = Interest

                };

                _context.InterestsTableAccess.Add(entity);
            }

            return await _context.SaveChangesAsync() == rao.Interests.Count;
        }

        public async Task<bool> DeleteInterests(int id)
        {
            var entity = await _context.InterestsTableAccess.SingleAsync(e => e.TransactionId == id);
            _context.InterestsTableAccess.Remove(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<InterestsGetListItemRAO> GetInterests(int OwnerId)
        {
            var query = _context.InterestsTableAccess.Where(e => e.OwnerId == OwnerId);
            var rao = new InterestsGetListItemRAO()
            {
                OwnerId = OwnerId,
                Interests = new List<int>()                
            };
            foreach (InterestsEntity entity in query)
            {
                rao.Interests.Add(entity.Interests);
            }

            return rao;
        }

        public async Task<bool> UpdateInterests(InterestsUpdateRAO rao)
        {
            var entity = await _context
            .InterestsTableAccess
            .SingleOrDefaultAsync(e => e.TransactionId == rao.TransactionId);

            entity.Interests = rao.Interest;


            return await _context.SaveChangesAsync() == 1;
        }
    }
}
