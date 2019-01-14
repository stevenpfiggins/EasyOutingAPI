using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Interests
{
    public enum InterestEnum
    {
        Canoeing = 1, Kyaking, Hiking, RockClimbing, Camping, Fishing, SightSeeing,
        Football, Basketball, Soccer, Baseball, Hockey, Tennis, Golf, Running, WeightLifting, Yoga,
        Gymnastics, Restaurants, Bars, Wineries, Consoles, BoardGames, CardGames, Arcades, Movies, Theatre,
        Concerts, Festivals, Clubs, Bowling, Zoo, Painting, Knitting, Pottery, Museums, Aquariums, Galleries
    }
    public class InterestsCreateRequest
    {
        public int UserId { get; set; }
        public List<int> Interests { get; set; }

    }
}
