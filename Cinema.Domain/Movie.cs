using Cinema.Domain.Enums;

namespace Cinema.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; }
        public int AgeRating { get; set; }
        public CountryType Country { get; set; }
        public MovieType Type { get; set; }
    }
}
