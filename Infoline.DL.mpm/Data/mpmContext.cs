using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infoline.DL.mpm.Data
{
    public class mpmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ArgeDB;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public DbSet<Entities.mpm> Mpms { get; set; }
    }
}
