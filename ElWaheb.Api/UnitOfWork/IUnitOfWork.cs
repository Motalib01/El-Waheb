using ElWaheb.Api.Entites;
using ElWaheb.Api.Repositores;

namespace ElWaheb.Api.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        //repositories
        //IRepository<User> Users { get; }
        IRepository<Notification> Notifications { get; }
        IRepository<DonationRequest> DonationRequests { get; }
        IRepository<Location> Locations { get; }
        Task<int> SaveChangesAsync();
    }
}
