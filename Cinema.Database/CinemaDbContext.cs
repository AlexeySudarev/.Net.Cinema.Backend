using Cinema.Application.Interfaces;
using Cinema.Database.EntityConfigurations;
using Cinema.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Database
{
    class CinemaDbContext : DbContext, ICinemaDbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CinemaConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
