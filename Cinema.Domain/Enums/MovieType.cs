namespace Cinema.Domain.Enums
{
    [Flags]
    public enum MovieType
    {
        None = 0,
        Biography = 1 << 0,
        Drama = 1 << 1,
        Melodrama = 1 << 2,
        Musical = 1 << 3,
        Detective = 1 << 4,
        Action = 1 << 5,
        History = 1 << 6,
        Comedy = 1 << 7,
        Cartoon = 1 << 8,
        Fantasy = 1 << 9,
        Family = 1 << 10,
        Animation = 1 << 11,
        Adventure = 1 << 12,
        SciFi = 1 << 13,
        War = 1 << 14
    }
}
