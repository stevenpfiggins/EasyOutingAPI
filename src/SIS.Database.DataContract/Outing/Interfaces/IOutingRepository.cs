using RedStarter.API.DataContract.Outing;
using RedStarter.Business.DataContract.Outing.DTOs;
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
        Task<IEnumerable<OutingGetListItemRAO>> GetOutings();
        Task<IEnumerable<OutingGetListItemRAO>> GetOutingsByUser(int id);
        Task<OutingGetByIdRAO> GetOutingById(int id);
        Task<bool> DeleteOuting(int id);
        Task<bool> OutingUpdate(OutingUpdateRAO rao);
    }
}
