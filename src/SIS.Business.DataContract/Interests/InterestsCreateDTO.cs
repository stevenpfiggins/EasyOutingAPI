using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Interests
{

    public class InterestsCreateDTO
    {
        public List<int> Interests { get; set; }
        public int UserId { get; set; }
    }
}
