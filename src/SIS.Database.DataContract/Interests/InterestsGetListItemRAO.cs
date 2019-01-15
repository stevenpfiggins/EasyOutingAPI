using RedStarter.API.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Interests
{

    public class InterestsGetListItemRAO
    {
        public int InterestsEntityId { get; set; }
        public int OwnerId { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
    }
}
