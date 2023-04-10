using Barbar.Core.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Barbar.Core.Repositories
{
    public interface IBarbarRepository : IRepository<Barbar.Core.Entities.Barbar>
    {
        //custom operations here
        Task<IEnumerable<Barbar.Core.Entities.Barbar>> GetBarbarByLastName(string lastname);
    }
}
