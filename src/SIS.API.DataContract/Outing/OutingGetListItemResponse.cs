using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Outing
{
    public class OutingGetListItemResponse
    {
        public int OutingEntityId { get; set; }
        public string OutingName { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public int OutingType { get; set; }
    }
}
