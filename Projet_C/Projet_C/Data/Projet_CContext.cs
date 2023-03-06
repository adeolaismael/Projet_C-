using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet_C.Models;

namespace Projet_C.Data
{
    public class Projet_CContext : DbContext
    {
        public Projet_CContext (DbContextOptions<Projet_CContext> options)
            : base(options)
        {
        }

        public DbSet<Projet_C.Models.Continent> Continent { get; set; } = default!;

        public DbSet<Projet_C.Models.Country> Country { get; set; }

        public DbSet<Projet_C.Models.Popcs> Popcs { get; set; }
    }
}
