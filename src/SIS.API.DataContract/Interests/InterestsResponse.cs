using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Interests
{
    public class InterestsResponse
    {
        public int InterestsEntityId { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
    }
}
