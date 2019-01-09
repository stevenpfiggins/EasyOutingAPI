using RedStarter.Database.DataContract.Outing.RAOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Outing.Interfaces
{
    public interface IOutingRepository
    {
        Task<bool> CreateOuting(OutingCreateRAO rao);
    }
}
