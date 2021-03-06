﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Interests
{

    public interface IInterestsManager
    {
        Task<bool> CreateInterests(InterestsCreateDTO dto);
        Task<IEnumerable<InterestsGetListItemDTO>> GetInterests();
        Task<IEnumerable<InterestsGetListItemDTO>> GetInterestsByUser(int id);
        Task<InterestsGetByIdDTO> GetInterestsByOwnerId(int id);
        Task<InterestsGetByIdDTO> GetInterestsByEntityId(int id);
        Task<bool> DeleteInterests(int id);
        Task<bool> UpdateInterests(InterestsUpdateDTO dto);

    }
}
