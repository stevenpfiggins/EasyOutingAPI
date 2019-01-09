using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Interests
{
    public interface IinterestsRepository
    {
        Task<bool> CreateInterests(InterestsCreateRAO rao);
    }
}
