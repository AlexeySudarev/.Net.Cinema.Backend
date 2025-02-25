using Cinema.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Domain
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; }

        [Required]
        public int AgeRating { get; set; }

        [Required]
        public CountryType Country { get; set; }

        [Required]
        public MovieType Type { get; set; }
    }
}
