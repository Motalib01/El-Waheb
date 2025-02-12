using ElWaheb.Api.Entites;

namespace ElWaheb.Api.Services
{
    public interface INotificationService
    {
        Task<IEnumerable<Notification>> GetAllNotificationsAsync();
        Task<Notification> GetNotificationByIdAsync(int id);
        Task CreateNotificationAsync(Notification notification);
        Task<bool> DeleteNotificationAsync(int id);
    }
}
