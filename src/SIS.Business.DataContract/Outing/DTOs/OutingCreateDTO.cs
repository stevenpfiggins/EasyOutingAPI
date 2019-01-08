using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Outing.DTOs
{
    public enum OutingType
    {
        Canoeing = 1, Kyaking, Hiking, RockClimbing, Camping, Fishing, SightSeeing,
        Football, Basketball, Soccer, Baseball, Hockey, Tennis, Golf, Running, WeightLifting, Yoga,
        Gymnastics, Restaurants, Bars, Wineries, Consoles, BoardGames, CardGames, Arcades, Movies, Theatre,
        Concerts, Festivals, Clubs, Bowling, Zoo, Painting, Knitting, Pottery, Museums, Aquariums, Galleries
    }

    public class OutingCreateDTO
    {
        public string OutingName { get; set; }
        public string OutingDescription { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public OutingType OutingType { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
