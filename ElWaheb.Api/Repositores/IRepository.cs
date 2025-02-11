using ElWaheb.Api.Entites;

namespace ElWaheb.Api.Repositores
{
    public interface IRepository<T> where T : Base
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
