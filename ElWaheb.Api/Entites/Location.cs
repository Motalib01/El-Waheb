namespace ElWaheb.Api.Entites
{
    public class Location: Base
    {
        public double Latitude { get; set; }
        public double Longititude { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public List<User> Users { get; set; }
    }
}
