using RedStarter.API.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Interests
{
    public class InterestsUpdateDTO
    {
        public int TransactionId { get; set; }
        public List<int> Interests { get; set; }
    }
}
