using DesafioBackendAlura.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBackendAlura.Data
{
    public class DesafioBackendAluraContext : DbContext
    {
        public DesafioBackendAluraContext( DbContextOptions<DesafioBackendAluraContext> options ) : base( options ) { }

        public DbSet<Video> Videos { get; set; }
    }
}
