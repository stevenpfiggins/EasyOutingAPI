using RedStarter.Business.DataContract.Interests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Interests
{
    //TODO 6: You need a GetALlInterests method here, too
    public interface IInterestsRepository
    {
        Task<bool> CreateInterests(InterestsCreateRAO rao);
        Task<IEnumerable<InterestsGetListItemRAO>> GetInterests();
        Task<InterestsGetByIdRAO> GetInterestsById(int id);
        Task<bool> UpdateInterests(InterestsUpdateRAO rao);
        Task<bool> DeleteInterests(int id);
    }
}
