using Barbar.Core.Repositories;
using Barbar.Infrastructure.Data;
using Barbar.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbar.Infrastructure.Repositories
{
    public class BarbarRepository : Repository<Barbar.Core.Entities.Barbar>, IBarbarRepository
    {
        public BarbarRepository(BarbarContext BarbarContext) : base(BarbarContext)
        {

        }
        public async Task<IEnumerable<Core.Entities.Barbar>> GetBarbarByLastName(string lastname)
        {
            return await _BarbarContext.Barbars
                .Where(m => m.LastName == lastname)
                .ToListAsync();
        }
    }
}
