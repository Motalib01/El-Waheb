﻿using ElWaheb.Api.Entites;
namespace ElWaheb.Api.Servises
{
    public interface IDonationRequestService
    {
        Task<IEnumerable<DonationRequest>> GetAllRequestsAsync();
        Task<DonationRequest> GetRequestByIdAsync(int id);
        Task CreateRequestAsync(DonationRequest request);
        Task<bool> DeleteRequestAsync(int id);
    }
}
