using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Interests
{
    public enum InterestEnum
    {
        Canoeing = 1, Kyaking, Hiking, RockClimbing, Camping, Fishing, SightSeeing,
        Football, Basketball, Soccer, Baseball, Hockey, Tennis, Golf, Running, WeightLifting, Yoga,
        Gymnastics, Restaurants, Bars, Wineries, Consoles, BoardGames, CardGames, Arcades, Movies, Theatre,
        Concerts, Festivals, Clubs, Bowling, Zoo, Painting, Knitting, Pottery, Museums, Aquariums, Galleries
    }

    public class InterestsCreateRAO
    {
        public List<InterestEnum> Interests { get; set; }
        public int UserId { get; set; }
    }
}
