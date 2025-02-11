namespace ElWaheb.Api.RequestsResponses
{
    public class RegisterRequest
    {
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string BloodType { get; set; }
    }
}
