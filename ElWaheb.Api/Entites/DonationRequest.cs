namespace ElWaheb.Api.Entites
{
    public class DonationRequest: Base
    {
        
        public string BloodType { get; set; }
        public string NeededDate { get; set; }
        public string Status { get; set; }
        public Guid LocationId { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }
        
    }
}
