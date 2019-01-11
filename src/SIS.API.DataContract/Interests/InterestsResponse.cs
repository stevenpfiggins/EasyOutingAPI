using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Interests
{
    public class InterestsResponse
    {
        public List<InterestEnum> Interests { get; set; }
        public int UserId { get; set; }
    }
}
