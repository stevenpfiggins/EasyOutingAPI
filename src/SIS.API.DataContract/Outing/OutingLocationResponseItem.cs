using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Outing
{
    public class OutingLocationResponseItem
    {
        public int OutingEntityId { get; set; }
        public int OwnerId { get; set; }
        public string OutingName { get; set; }
        public string OutingLocation { get; set; }
        public string UserLocation { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public string OutingType { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
