using ElWaheb.Api.Data;
using ElWaheb.Api.Entites;
using ElWaheb.Api.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ElWaheb.Api.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DbContext _context;
        public IRepository<User> Users { get; }
        public IRepository<Notification> Notifications { get; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new Repository<User>(context);
            Notifications = new Repository<Notification>(context);
        }

        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
