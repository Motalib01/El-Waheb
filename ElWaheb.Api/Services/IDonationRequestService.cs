using ElWaheb.Api.Entites;

namespace ElWaheb.Api.Services
{
    public interface IDonationRequestService
    {
        public Task<IEnumerable<DonationRequest>> GetAllDonationRequestAsync();
        public Task CreateDonationRequestAsync(DonationRequest request);

    }
}
