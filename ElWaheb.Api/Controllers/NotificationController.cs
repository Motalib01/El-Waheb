using ElWaheb.Api.Entites;
using ElWaheb.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElWaheb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public async Task<IEnumerable<Notification>> GetAllNotificationsAsync()
        {
            return await _notificationService.GetAllNotificationsAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNotificationAsync(Notification notification)
        {
            await _notificationService.CreateNotificationAsync(notification);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotificationAsync(Guid id)
        {
            var result = await _notificationService.DeleteNotificationAsync(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }

    }
}
