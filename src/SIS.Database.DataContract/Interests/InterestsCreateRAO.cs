using RedStarter.API.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Interests
{
    public class InterestsCreateRAO
    {
        public int UserId { get; set; }
        public List<int> Interests { get; set; }
    }
}
