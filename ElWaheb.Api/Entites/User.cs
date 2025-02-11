using Microsoft.AspNetCore.Identity;

namespace ElWaheb.Api.Entites
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        //public string Email { get; set; }
        public string BloodType { get; set; }
        //public string password { get; set; }

        public List<DonationRequest> DonationRequests { get; set; }
        public List<Notification> Notifications { get; set; }

        public Guid? LocationId { get; set; }
        public Location Location { get; set; }

    }
}
