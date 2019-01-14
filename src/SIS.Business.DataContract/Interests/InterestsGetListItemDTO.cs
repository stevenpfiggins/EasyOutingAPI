using RedStarter.API.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Interests
{
    public class InterestsGetListItemDTO
    {
        public int OwnerId { get; set; }
        public List<int> Interests { get; set; }
    }
}
