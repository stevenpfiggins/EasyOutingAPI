using AutoMapper;
using RedStarter.Business.DataContract.Outing.DTOs;
using RedStarter.Business.DataContract.Outing.Interfaces;
using RedStarter.Database.DataContract.Interests;
using RedStarter.Database.DataContract.Outing.Interfaces;
using RedStarter.Database.DataContract.Outing.RAOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var listOfOutings = new List<OutingGetListItemRAO>();

            foreach (var item in rao)
            {
                listOfOutings.Add(item);
            }

            var orderedList = listOfOutings.OrderBy(e => e.OutingDate).ToList();
            var dto = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(orderedList);

            return dto;
        }

        public async Task<IEnumerable<OutingGetListItemDTO>> GetOutingsByMatchedInterestsProfile(int id)
        {
            var rao = await _outingRepository.GetOutings();
            var interestsRao = await _interestsRepository.GetInterestsByOwnerId(id);
            var collectionOfMatchedLocationAndInterests = new List<OutingGetListItemRAO>();

            foreach (var item in rao)
            {
                if (interestsRao.Canoeing)
                {
                    string canoeing = "Canoeing";
                    if (item.OutingType == canoeing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Kayaking)
                {
                    string kayaking = "Kayaking";
                    if (item.OutingType == kayaking && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Hiking)
                {
                    string hiking = "Hiking";
                    if (item.OutingType == hiking && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.RockClimbing)
                {
                    string rockClimbing = "RockClimbing";
                    if (item.OutingType == rockClimbing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Camping)
                {
                    string camping = "Camping";
                    if (item.OutingType == camping && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Fishing)
                {
                    string fishing = "Fishing";
                    if (item.OutingType == fishing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.SightSeeing)
                {
                    string sightSeeing = "SightSeeing";
                    if (item.OutingType == sightSeeing && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Football)
                {
                    string football = "Football";
                    if (item.OutingType == football && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Basketball)
                {
                    string basketball = "Basketball";
                    if (item.OutingType == basketball && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Soccer)
                {
                    string soccer = "Soccer";
                    if (item.OutingType == soccer && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Baseball)
                {
                    string baseball = "Baseball";
                    if (item.OutingType == baseball && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Hockey)
                {
                    string hockey = "Hockey";
                    if (item.OutingType == hockey && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Tennis)
                {
                    string tennis = "Tennis";
                    if (item.OutingType == tennis && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Golf)
                {
                    string golf = "Golf";
                    if (item.OutingType == golf && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Running)
                {
                    string running = "Running";
                    if (item.OutingType == running && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.WeightLifting)
                {
                    string weightLifting = "WeightLifting";
                    if (item.OutingType == weightLifting && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Yoga)
                {
                    string yoga = "Yoga";
                    if (item.OutingType == yoga && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Gymnastics)
                {
                    string gymnastics = "Gymnastics";
                    if (item.OutingType == gymnastics && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Restaurants)
                {
                    string restaurants = "Restaurants";
                    if (item.OutingType == restaurants && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Bars)
                {
                    string bars = "Bars";
                    if (item.OutingType == bars && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Wineries)
                {
                    string wineries = "Wineries";
                    if (item.OutingType == wineries && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Consoles)
                {
                    string consoles = "Consoles";
                    if (item.OutingType == consoles && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.BoardGames)
                {
                    string boardGames = "BoardGames";
                    if (item.OutingType == boardGames && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.CardGames)
                {
                    string cardGames = "CardGames";
                    if (item.OutingType == cardGames && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Arcades)
                {
                    string arcades = "Arcades";
                    if (item.OutingType == arcades && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Movies)
                {
                    string movies = "Movies";
                    if (item.OutingType == movies && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Theatre)
                {
                    string theatre = "Theatre";
                    if (item.OutingType == theatre && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Concerts)
                {
                    string concerts = "Concerts";
                    if (item.OutingType == concerts && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Festivals)
                {
                    string festivals = "Festivals";
                    if (item.OutingType == festivals && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Clubs)
                {
                    string clubs = "Clubs";
                    if (item.OutingType == clubs && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Bowling)
                {
                    string bowling = "Bowling";
                    if (item.OutingType == bowling && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Zoo)
                {
                    string zoo = "Zoo";
                    if (item.OutingType == zoo && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Painting)
                {
                    string painting = "Painting";
                    if (item.OutingType == painting && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }                

                if (interestsRao.Knitting)
                {
                    string knitting = "Knitting";
                    if (item.OutingType == knitting && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }                

                if (interestsRao.Pottery)
                {
                    string pottery = "Pottery";
                    if (item.OutingType == pottery && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }                

                if (interestsRao.Museums)
                {
                    string museums = "Museums";
                    if (item.OutingType == museums && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Aquariums)
                {
                    string aquariums = "Aquariums";
                    if (item.OutingType == aquariums && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }

                if (interestsRao.Galleries)
                {
                    string galleries = "Galleries";
                    if (item.OutingType == galleries && item.OutingLocation == interestsRao.UserLocation && item.OutingDate >= DateTimeOffset.Now && item.OwnerId != interestsRao.OwnerId)
                    {
                        collectionOfMatchedLocationAndInterests.Add(item);
                    }
                }
            }

            var orderedList = collectionOfMatchedLocationAndInterests.OrderBy(e => e.OutingDate).ToList();

            var matchedList = _mapper.Map<IEnumerable<OutingGetListItemDTO>>(orderedList);
            
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
