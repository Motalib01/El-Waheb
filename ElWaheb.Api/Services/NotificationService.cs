using ElWaheb.Api.Entites;
using ElWaheb.Api.UnitOfWork;

namespace ElWaheb.Api.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateNotificationAsync(Notification notification)
        {
            await _unitOfWork.Notifications.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> DeleteNotificationAsync(Guid id)
        {
            var notification = await _unitOfWork.Notifications.GetByIdAsync(id);
            if (notification == null)
                return false;

            _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Notification>> GetAllNotificationsAsync()=> await _unitOfWork.Notifications.GetAllAsync();

        public async Task<Notification> GetNotificationByIdAsync(Guid id)=> await _unitOfWork.Notifications.GetByIdAsync(id);
    }
}
