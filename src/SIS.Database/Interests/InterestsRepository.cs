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
            var entity = _mapper.Map<InterestsEntity>(rao);

            await _context.InterestsTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<InterestsGetListItemRAO>> GetInterests()
        {
            var entity = await _context.InterestsTableAccess.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<InterestsGetListItemRAO>>(entity);

            return rao;
        }

        public async Task<IEnumerable<InterestsGetListItemRAO>> GetInterestsByUser(int id)
        {
            var entity = await _context.InterestsTableAccess.Where(e => e.OwnerId == id).ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<InterestsGetListItemRAO>>(entity);

            return rao;
        }

        public async Task<InterestsGetByIdRAO> GetInterestsByOwnerId(int id)
        {
            var entity = await _context.InterestsTableAccess.SingleOrDefaultAsync(e => e.OwnerId == id);
            var rao = _mapper.Map<InterestsGetByIdRAO>(entity);

            return rao;
        }

        public async Task<bool> UpdateInterests(InterestsUpdateRAO rao)
        {
            var entity = await _context
            .InterestsTableAccess
            .SingleOrDefaultAsync(e => e.InterestsEntityId == rao.InterestsEntityId);
            
            entity.UserLocation = rao.UserLocation;
            entity.Aquariums = rao.Aquariums;
            entity.Arcades = rao.Arcades;
            entity.Bars = rao.Bars;
            entity.Baseball = rao.Baseball;
            entity.Basketball = rao.Basketball;
            entity.BoardGames = rao.BoardGames;
            entity.Bowling = rao.Bowling;
            entity.Camping = rao.Camping;
            entity.Canoeing = rao.Canoeing;
            entity.CardGames = rao.CardGames;
            entity.Clubs = rao.Clubs;
            entity.Concerts = rao.Concerts;
            entity.Consoles = rao.Consoles;
            entity.Festivals = rao.Festivals;
            entity.Fishing = rao.Fishing;
            entity.Football = rao.Football;
            entity.Galleries = rao.Galleries;
            entity.Golf = rao.Golf;
            entity.Gymnastics = rao.Gymnastics;
            entity.Hiking = rao.Hiking;
            entity.Hockey = rao.Hockey;
            entity.Kayaking = rao.Kayaking;
            entity.Knitting = rao.Knitting;
            entity.Movies = rao.Movies;
            entity.Museums = rao.Museums;
            entity.Painting = rao.Painting;
            entity.Pottery = rao.Pottery;
            entity.Restaurants = rao.Restaurants;
            entity.RockClimbing = rao.RockClimbing;
            entity.Running = rao.Running;
            entity.SightSeeing = rao.SightSeeing;
            entity.Soccer = rao.Soccer;
            entity.Tennis = rao.Tennis;
            entity.Theatre = rao.Theatre;
            entity.WeightLifting = rao.WeightLifting;
            entity.Wineries = rao.Wineries;
            entity.Yoga = rao.Yoga;
            entity.Zoo = rao.Zoo;

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteInterests(int id)
        {
            var entity = await _context.InterestsTableAccess.SingleAsync(e => e.InterestsEntityId == id);
            _context.InterestsTableAccess.Remove(entity);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
