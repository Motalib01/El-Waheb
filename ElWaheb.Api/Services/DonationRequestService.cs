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
        
    }
}
