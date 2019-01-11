using RedStarter.API.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Interests
{
    public class InterestsGetListItemDTO
    {
        public int UserId { get; set; }
        public List<InterestEnum> Interests { get; set; }
    }
}
