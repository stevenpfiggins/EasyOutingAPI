using RedStarter.API.DataContract.Interests;
using RedStarter.Database.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Interests
{

    public class InterestsEntity
    {
        [Key]
        public int InterestsEntityId { get; set; }

        [Required]
        public int OwnerId { get; set; }

        [Required]
        public string UserName { get; set; }

        public string UserLocation { get; set; }
        public bool Canoeing { get; set; }
        public bool Kayaking { get; set; }
        public bool Hiking { get; set; }
        public bool RockClimbing { get; set; }
        public bool Camping { get; set; }
        public bool Fishing { get; set; }
        public bool SightSeeing { get; set; }
        public bool Football { get; set; }
        public bool Basketball { get; set; }
        public bool Soccer { get; set; }
        public bool Baseball { get; set; }
        public bool Hockey { get; set; }
        public bool Tennis { get; set; }
        public bool Golf { get; set; }
        public bool Running { get; set; }
        public bool WeightLifting { get; set; }
        public bool Yoga { get; set; }
        public bool Gymnastics { get; set; }
        public bool Restaurants { get; set; }
        public bool Bars { get; set; }
        public bool Wineries { get; set; }
        public bool Consoles { get; set; }
        public bool BoardGames { get; set; }
        public bool CardGames { get; set; }
        public bool Arcades { get; set; }
        public bool Movies { get; set; }
        public bool Theatre { get; set; }
        public bool Concerts { get; set; }
        public bool Festivals { get; set; }
        public bool Clubs { get; set; }
        public bool Bowling { get; set; }
        public bool Zoo { get; set; }
        public bool Painting { get; set; }
        public bool Knitting { get; set; }
        public bool Pottery { get; set; }
        public bool Museums { get; set; }
        public bool Aquariums { get; set; }
        public bool Galleries { get; set; }
    }
}
