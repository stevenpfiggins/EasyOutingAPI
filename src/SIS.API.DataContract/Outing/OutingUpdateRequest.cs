using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Outing
{
    public class OutingUpdateRequest
    {
        public int OutingEntityId { get; set; }
        public int OwnerId { get; set; }
        public string OutingName { get; set; }
        public string OutingDescription { get; set; }
        public string OutingLocation { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public int OutingType { get; set; }
    }
}
