using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Outing.RAOs
{
    public class OutingGetListItemRAO
    {
        public int OutingEntityId { get; set; }
        public string OutingName { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public int OutingType { get; set; }
    }
}
