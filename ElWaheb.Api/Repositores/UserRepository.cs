using ElWaheb.Api.Data;
using ElWaheb.Api.Entites;
using Microsoft.EntityFrameworkCore;

namespace ElWaheb.Api.Repositores
{
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)=> await _context.Users.AddAsync(entity);

        public void Delete(User entity) => _context.Users.Remove(entity);

        public async Task<IEnumerable<User>> GetAllAsync() 
            => await _context.Users.AsNoTracking().ToListAsync();

        public async Task<User> GetByIdAsync(Guid id)
            => await _context.Users.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id.ToString());

        public void Update(User entity) => _context.Users.Update(entity);
    }
}
