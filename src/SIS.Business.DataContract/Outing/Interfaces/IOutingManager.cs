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
        Task<IEnumerable<OutingGetListItemDTO>> GetOutingsByUser(int id);
        Task<OutingGetByIdDTO> GetOutingById(int id);
        Task<bool> DeleteOuting(int id);
        Task<bool> OutingUpdate(OutingUpdateDTO dto);
        Task <IEnumerable<OutingGetListItemDTO>> GetOutingsByInterestsLocation(int id);
    }
}
