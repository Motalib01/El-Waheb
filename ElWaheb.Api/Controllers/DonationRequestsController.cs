using ElWaheb.Api.Entites;
using ElWaheb.Api.Servises;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElWaheb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationRequestsController : ControllerBase
    {
        private readonly IDonationRequestService _donationRequestService;
        public DonationRequestsController(IDonationRequestService donationRequestService)
        {
            _donationRequestService = donationRequestService;
        }

        [HttpGet]
        public async Task<IEnumerable<DonationRequest>> GetAllRequestsAsync()
        {
            return await _donationRequestService.GetAllRequestsAsync();
        }

        [HttpGet("{id}")]
        public async Task<DonationRequest> GetRequestByIdAsync(int id)
        {
            return await _donationRequestService.GetRequestByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequestAsync(DonationRequest request)
        {
            await _donationRequestService.CreateRequestAsync(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequestAsync(int id)
        {
            var result = await _donationRequestService.DeleteRequestAsync(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
