namespace Zasilkovna.Data
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Place { get; set; } = "";
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public string Zip { get; set; } = "";
        public string Country { get; set; } = "";
        public string Currency { get; set; } = "";
        public string Latitude { get; set; } = "";
        public string Longitude { get; set; } = "";
        public List<Photo>? Photos { get; set; }
        public OpeningHours? OpeningHours { get; set; }
        public string Url { get; set; } = "";

    }

    public class Photo
    {
        public string Thumbnail { get; set; } = "";
        public string Normal { get; set; } = "";
    }

    public class OpeningHours
    {
        public string CompactShort { get; set; } = "";
        public string CompactLong { get; set; } = "";
        public string Monday { get; set; } = "";
        public string Tuesday { get; set; } = "";
        public string Wednesday { get; set; } = "";
        public string Thursday { get; set; } = "";
        public string Friday { get; set; } = "";
        public string Saturday { get; set; } = "";
        public string Sunday { get; set; } = "";
    }
}
