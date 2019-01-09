using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Outing
{
    public enum OutingType
    {
        Canoeing = 1, Kayaking, Hiking, RockClimbing, Camping, Fishing, SightSeeing,
        Football, Basketball, Soccer, Baseball, Hockey, Tennis, Golf, Running, WeightLifting, Yoga,
        Gymnastics, Restaurants, Bars, Wineries, Consoles, BoardGames, CardGames, Arcades, Movies, Theatre,
        Concerts, Festivals, Clubs, Bowling, Zoo, Painting, Knitting, Pottery, Museums, Aquariums, Galleries
    }

    public class OutingEntity
    {
        [Key]
        public int OutingEntityId { get; set; }

        [Required]
        public string OutingName { get; set; }

        [Required]
        public string OutingDescription { get; set; }

        [Required]
        public DateTimeOffset OutingDate { get; set; }

        [Required]
        public OutingType OutingType { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedOn { get; set; }

        [Required]
        public int OwnerId { get; set; }
    }
}
