
using com.productManagementSystem.DBEntity.DataModels;
using com.productManagementSystem.DBEntity.ViewModels;

namespace com.productManagementSystem.generic.repositories.Interface
{
    public interface IGenericRepositories<T> where T : class
    {
        public Task AddAsync(T entity);
        public T Add(T model);
        public Task UpdateAsync(T entity);
        public T Update(T model);
        public Task RemoveAsync(T entity);
        public T Remove(T model);
        public IQueryable<T> GetAll();
        public OrderProduct GetOrderById(int orderId);
    }
}
