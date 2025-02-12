using ElWaheb.Api.Entites;

namespace ElWaheb.Api.Services
{
    public interface ILocationService
    {
        Task<IEnumerable<Location>> GetAllLocationsAsync();
        Task<Location> GetLocationByIdAsync(int id);
        Task CreateLocationAsync(Location location);
        Task<bool> DeleteLocationAsync(int id);
    }
}
