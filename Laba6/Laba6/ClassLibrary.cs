using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Laba6
{
   public class ClassLibrary: DbContext
    {
        public ClassLibrary(string nameOrConnectionString) : base(nameOrConnectionString) { }
        public DbSet<Instytyts> Instytyts { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Kafedra> Kafedra { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

    }
}
