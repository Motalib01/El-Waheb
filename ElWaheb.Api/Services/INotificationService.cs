using ElWaheb.Api.Entites;

namespace ElWaheb.Api.Services
{
    public interface INotificationService
    {
        Task<IEnumerable<Notification>> GetAllNotificationsAsync();
        Task<Notification> GetNotificationByIdAsync(Guid id);
        Task CreateNotificationAsync(Notification notification);
        Task<bool> DeleteNotificationAsync(Guid id);
    }
}
