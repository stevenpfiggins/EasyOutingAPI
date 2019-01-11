using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Interests
{
    public class InterestsUpdateItem
    {
        public int TransactionId { get; set; }
        public List<InterestEnum> Interests { get; set; }
    }
}
