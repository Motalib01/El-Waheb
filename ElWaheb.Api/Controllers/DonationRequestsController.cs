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

        
    }
}
