using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace Cmpe232Web.Data
{
    public class Cmpe232WebContext : DbContext
    {
        public Cmpe232WebContext (DbContextOptions<Cmpe232WebContext> options)
            : base(options)
        {
        }

        public DbSet<DataAccess.Route> Route { get; set; } = default!;
        public DbSet<DataAccess.Bus> Bus { get; set; } = default!;
    }
}
