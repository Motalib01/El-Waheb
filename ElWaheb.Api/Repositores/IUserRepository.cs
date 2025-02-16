using ElWaheb.Api.Entites;

namespace ElWaheb.Api.Repositores
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid id);
        Task AddAsync(User entity);
        void Update(User entity);
        void Delete(User entity);
    }
}
