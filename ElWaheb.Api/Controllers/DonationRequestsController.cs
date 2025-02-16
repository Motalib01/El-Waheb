using ElWaheb.Api.Entites;
using ElWaheb.Api.Services;
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

        [HttpGet("get-Donation-Requests")]
        public async Task<IActionResult> GetDonationRequests()
        {
            var requests= await _donationRequestService.GetAllDonationRequestAsync();
            return Ok(requests);
        }

        [HttpPost("create-Donation-Request")]
        public async Task<IActionResult> CreateDonationRequest([FromBody] DonationRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _donationRequestService.CreateDonationRequestAsync(request);
            return Ok("Donation request created and notifications sent.");
        }
    }
}
