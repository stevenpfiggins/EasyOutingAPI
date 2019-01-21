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

        public async Task<IEnumerable<OutingGetListItemDTO>> GetOutingsByMatchedInterestsProfile(int id)
        {
            var rao = await _outingRepository.GetOutings();
            var interestsRao = await _interestsRepository.GetInterestsByOwnerId(id);
            var collectionOfMatchedLocationAndInterests = new List<OutingGetListItemRAO>();

            foreach (var item in rao)
            {
                string canoeing;
                string kayaking;
                string hiking;
                string rockClimbing;
                string camping;
                string fishing;
                string sightSeeing;
                string football;
                string basketball;
                string soccer;
                string baseball;
                string hockey;
                string tennis;
                string golf;
                string running;
                string weightLifting;
                string yoga;
                string gymnastics;
                string restaurants;
                string bars;
                string wineries;
                string consoles;
                string boardGames;
                string cardGames;
                string arcades;
                string movies;
                string theatre;
                string concerts;
                string festivals;
                string clubs;
                string bowling;
                string zoo;
                string painting;
                string knitting;
                string pottery;
                string museums;
                string aquariums;
                string galleries;

                if (interestsRao.Canoeing)
                {
                    canoeing = "Canoeing";
                    if (item.OutingType == canoeing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Kayaking)
                {
                    kayaking = "Kayaking";
                    if (item.OutingType == kayaking && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Hiking)
                {
                    hiking = "Hiking";
                    if (item.OutingType == hiking && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.RockClimbing)
                {
                    rockClimbing = "RockClimbing";
                    if (item.OutingType == rockClimbing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Camping)
                {
                    camping = "Camping";
                    if (item.OutingType == camping && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Fishing)
                {
                    fishing = "Fishing";
                    if (item.OutingType == fishing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.SightSeeing)
                {
                    sightSeeing = "SightSeeing";
                    if (item.OutingType == sightSeeing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Football)
                {
                    football = "Football";
                    if (item.OutingType == football && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Basketball)
                {
                    basketball = "Basketball";
                    if (item.OutingType == basketball && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Soccer)
                {
                    soccer = "Soccer";
                    if (item.OutingType == soccer && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Baseball)
                {
                    baseball = "Baseball";
                    if (item.OutingType == baseball && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Hockey)
                {
                    hockey = "Hockey";
                    if (item.OutingType == hockey && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Tennis)
                {
                    tennis = "Tennis";
                    if (item.OutingType == tennis && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Golf)
                {
                    golf = "Golf";
                    if (item.OutingType == golf && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Running)
                {
                    running = "Running";
                    if (item.OutingType == running && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.WeightLifting)
                {
                    weightLifting = "WeightLifting";
                    if (item.OutingType == weightLifting && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Yoga)
                {
                    yoga = "Yoga";
                    if (item.OutingType == yoga && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Gymnastics)
                {
                    gymnastics = "Gymnastics";
                    if (item.OutingType == gymnastics && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Restaurants)
                {
                    restaurants = "Restaurants";
                    if (item.OutingType == restaurants && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Bars)
                {
                    bars = "Bars";
                    if (item.OutingType == bars && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Wineries)
                {
                    wineries = "Wineries";
                    if (item.OutingType == wineries && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Consoles)
                {
                    consoles = "Consoles";
                    if (item.OutingType == consoles && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.BoardGames)
                {
                    boardGames = "BoardGames";
                    if (item.OutingType == boardGames && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.CardGames)
                {
                    cardGames = "CardGames";
                    if (item.OutingType == cardGames && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Arcades)
                {
                    arcades = "Arcades";
                    if (item.OutingType == arcades && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Movies)
                {
                    movies = "Movies";
                    if (item.OutingType == movies && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Theatre)
                {
                    theatre = "Theatre";
                    if (item.OutingType == theatre && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Concerts)
                {
                    concerts = "Concerts";
                    if (item.OutingType == concerts && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Festivals)
                {
                    festivals = "Festivals";
                    if (item.OutingType == festivals && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Clubs)
                {
                    clubs = "Clubs";
                    if (item.OutingType == clubs && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Bowling)
                {
                    bowling = "Bowling";
                    if (item.OutingType == bowling && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Zoo)
                {
                    zoo = "Zoo";
                    if (item.OutingType == zoo && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Painting)
                {
                    painting = "Painting";
                    if (item.OutingType == painting && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }                

                if (interestsRao.Knitting)
                {
                    knitting = "Knitting";
                    if (item.OutingType == knitting && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }                

                if (interestsRao.Pottery)
                {
                    pottery = "Pottery";
                    if (item.OutingType == pottery && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }                

                if (interestsRao.Museums)
                {
                    museums = "Museums";
                    if (item.OutingType == museums && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Aquariums)
                {
                    aquariums = "Aquariums";
                    if (item.OutingType == aquariums && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Galleries)
                {
                    galleries = "Galleries";
                    if (item.OutingType == galleries && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }
            }

            var matchedList = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(collectionOfMatchedLocationAndInterests);
            
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
