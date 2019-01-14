using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Interests
{
    public class InterestsUpdateItem
    {
        public int TransactionId { get; set; }
        public List<int> Interests { get; set; }
    }
}
