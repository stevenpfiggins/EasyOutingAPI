using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Interests
{
    public class InterestsResponse
    {
        public List<int> Interests { get; set; }
        public int OwnerId { get; set; }

    }
}
