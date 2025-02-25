using Cinema.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Database.EntityConfigurations
{
    class CinemaConfiguration : IEntityTypeConfiguration<Movie>
    {
        private const int StringMaxLength = 100;

        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(movie => movie.Id);
            builder.Property(movie => movie.Title).IsRequired().HasMaxLength(StringMaxLength);
            builder.Property(movie => movie.Year).IsRequired();
            builder.Property(movie => movie.AgeRating).IsRequired();
            builder.Property(movie => movie.Country).IsRequired();
            builder.Property(movie => movie.Type).IsRequired();

            builder.HasIndex(movie => movie.Title).IsUnique();
        }
    }
}
