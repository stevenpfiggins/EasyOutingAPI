using RedStarter.API.DataContract.Outing;
using RedStarter.Business.DataContract.Outing.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Outing.Interfaces
{
    public interface IOutingManager
    {
        Task<bool>CreateOuting(OutingCreateDTO dto);
        Task<IEnumerable<OutingGetListItemDTO>> GetOutings();
        Task<OutingGetListItemDTO> GetOutingById(int id);
        Task<bool> DeleteOuting(int id);
    }
}
