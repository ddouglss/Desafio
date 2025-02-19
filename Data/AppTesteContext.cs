using Microsoft.EntityFrameworkCore;

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
