using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbar.Infrastructure.Data
{
    public class BarbarContext : DbContext
    {
        public BarbarContext(DbContextOptions<BarbarContext> options) : base (options)
        {

        }

        public DbSet<Barbar.Core.Entities.Barbar> Barbars { get; set; }
    }
}
