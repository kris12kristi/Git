using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace Laba8.Models
{
    public class LabContext: DbContext
    {
        public DbSet<Instutyt> Instutyts { get; set;}
        public DbSet<Kafedra> Kafedras { get; set;}
        public DbSet<Teachers> Teacher { get; set;}
        public DbSet<Subjects> Subject { get; set;}
    }
}