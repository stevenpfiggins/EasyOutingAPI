﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Outing.DTOs
{
    public class OutingUpdateDTO
    {
        public int OutingEntityId { get; set; }
        public string OutingName { get; set; }
        public string OutingDescription { get; set; }
        public string OutingLocation { get; set; }
        public DateTimeOffset OutingDate { get; set; }
        public int OutingType { get; set; }
    }
}
