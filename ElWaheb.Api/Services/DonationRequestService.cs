using ElWaheb.Api.Entites;
using ElWaheb.Api.UnitOfWork;

namespace ElWaheb.Api.Services
{
    public class DonationRequestService : IDonationRequestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DonationRequestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateRequestAsync(DonationRequest request)
        {
            await _unitOfWork.DonationRequests.AddAsync(request);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> DeleteRequestAsync(int id)
        {
            var request =await _unitOfWork.DonationRequests.GetByIdAsync(id);
            if (request == null) 
                return false;

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<DonationRequest>> GetAllRequestsAsync()=> await _unitOfWork.DonationRequests.GetAllAsync();

        public async Task<DonationRequest> GetRequestByIdAsync(int id)=> await _unitOfWork.DonationRequests.GetByIdAsync(id);
    }
}
