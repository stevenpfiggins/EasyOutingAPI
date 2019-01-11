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
        public int TransactionId { get; set; }
        public int OwnerId { get; set; }
        public InterestEnum Interests { get; set; }
    }
}
