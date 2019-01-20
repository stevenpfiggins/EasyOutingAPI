using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Outing.RAOs
{
    public class OutingGetByIdRAO
    {
        public int OutingEntityId { get; set; }
        public int OwnerId { get; set; }
        public string OutingName { get; set; }
        public string OutingDescription { get; set; }
        public string OutingLocation { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public string OutingType { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
