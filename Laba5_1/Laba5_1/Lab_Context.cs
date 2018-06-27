using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Laba5_1
{    //Contecst of Database
    public class Lab_Context : DbContext
    {
        public Lab_Context() : base("Laba5_1") { }
        public DbSet<Instytyts> Instytyts { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Kafedra> Kafedra { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<InterStudent> InterStudent { get; set; }
    }
    
}
