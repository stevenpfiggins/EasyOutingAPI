using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Interests;
using RedStarter.Database.Entities.Interests;
using RedStarter.Database.Entities.People;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Interests
{
    public class InterestsRepository : IinterestsRepository
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
            foreach (InterestEnum Interest in rao.Interests)
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

    }
}
