using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Outing.RAOs
{
    
    public class OutingUpdateRAO
    {
        public string OutingName { get; set; }
        public string OutingDescription { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public OutingType OutingType { get; set; }
        public string CreatedBy { get; set; }
        public int OwnerId { get; set; }
    }
}
