using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppTeste.Models;
using AppTeste.Data;

namespace AppTeste.Data
{
    public class AppTesteContext : DbContext
    {
        public AppTesteContext (DbContextOptions<AppTesteContext> options)
            : base(options)
        {
        }

        public DbSet<AppTeste.Models.Ring> Ring { get; set; } = default!;
    }
}
