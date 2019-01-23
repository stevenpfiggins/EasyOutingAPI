using RedStarter.Business.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Interests
{
    public interface IInterestsRepository
    {
        Task<bool> CreateInterests(InterestsCreateRAO rao);
        Task<IEnumerable<InterestsGetListItemRAO>> GetInterests();
        Task<IEnumerable<InterestsGetListItemRAO>> GetInterestsByUser(int id);
        Task<InterestsGetByIdRAO> GetInterestsByOwnerId(int id);
        Task<InterestsGetByIdRAO> GetInterestsByEntityId(int id);
        Task<bool> UpdateInterests(InterestsUpdateRAO rao);
        Task<bool> DeleteInterests(int id);
    }
}
