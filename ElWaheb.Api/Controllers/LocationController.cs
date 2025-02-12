using ElWaheb.Api.Entites;
using ElWaheb.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElWaheb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        [HttpGet]
        public async Task<IEnumerable<Location>> GetAllLocationsAsync()
        {
            return await locationService.GetAllLocationsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Location> GetLocationByIdAsync(int id)
        {
            return await locationService.GetLocationByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocationAsync(Location location)
        {
            await locationService.CreateLocationAsync(location);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocationAsync(int id)
        {
            var result = await locationService.DeleteLocationAsync(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
 