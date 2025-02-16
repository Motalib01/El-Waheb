namespace ElWaheb.Api.RequestsResponses
{
    public class GetUserRequestResponse
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateOnly? BirthDate { get; set; }
    }
}
