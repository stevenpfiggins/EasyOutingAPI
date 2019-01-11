using RedStarter.API.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Interests
{
    public class InterestsUpdateRAO
    {
        public int TransactionId { get; set; }
        public InterestEnum Interest { get; set; }
    }
}
