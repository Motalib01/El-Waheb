namespace ElWaheb.Api.RequestsResponses
{
    public class UpdateProfileRequest 
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
    }
}
