using ElWaheb.Api.Entites;
using ElWaheb.Api.UnitOfWork;

namespace ElWaheb.Api.Services
{
    public class LocationService : ILocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateLocationAsync(Location location)
        {
            await _unitOfWork.Locations.AddAsync(location);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> DeleteLocationAsync(int id)
        {
            var location = await _unitOfWork.Locations.GetByIdAsync(id);
            if (location == null)
                return false;

            _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Location>> GetAllLocationsAsync()=> await _unitOfWork.Locations.GetAllAsync();

        public async Task<Location> GetLocationByIdAsync(int id)=> await _unitOfWork.Locations.GetByIdAsync(id);
    }
}
