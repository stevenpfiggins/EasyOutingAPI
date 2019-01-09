using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Interests
{
    public interface IinterestsManager
    {
        Task<bool> CreateInterests(InterestsCreateDTO dto);
    }
}
