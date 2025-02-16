using ElWaheb.Api.Entites;
using ElWaheb.Api.UnitOfWork;

namespace ElWaheb.Api.Services
{
    public class DonationRequestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DonationRequestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DonationRequest>> GetAllDonationRequestAsync()=> await _unitOfWork.DonationRequests.GetAllAsync();

        public async Task CreateDonationRequestAsync(DonationRequest request)
        {
            await _unitOfWork.DonationRequests.AddAsync(request);
            await _unitOfWork.SaveChangesAsync();

            var nearbyUsers = await GetNearbyUsersAsync(request.Latitude, request.Longitude);

            foreach (var user in nearbyUsers)
            {
                var notification = new Notification
                {
                    UserId = user.Id,
                    Body = $"Urgent blood request for {request.BloodType} near your location!",
                    SentAt = DateTime.UtcNow
                };
                await _unitOfWork.Notifications.AddAsync(notification);
            }

            await _unitOfWork.SaveChangesAsync();
        }

        private async Task<IEnumerable<User>> GetNearbyUsersAsync(double lat, double lng)
        {
            var users = await _unitOfWork.Users.GetAllAsync();

            return users.Where(user =>
                CalculateDistance(lat, lng, user.Latitude, user.Longitude) <= 30);
        }

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // Earth radius in km
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private double ToRadians(double angle) => Math.PI * angle / 180;

    }
}
