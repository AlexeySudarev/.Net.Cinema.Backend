using Cinema.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Application.Interfaces
{
    public interface ICinemaDbContext
    {
        DbSet<Movie> Movies { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
