using com.productManagementSystem.DBEntity.DataContext;
using com.productManagementSystem.DBEntity.DataModels;
using com.productManagementSystem.generic.repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace com.productManagementSystem.generic.repositories
{
    public class GenericRepositories<T> : IGenericRepositories<T> where T : class
    {
        private readonly ProductManagementSystemContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepositories(ProductManagementSystemContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
        public T Add(T model)
        {
            _context.Add(model);
            _context.SaveChanges();

            return model;
        }
        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
        public T Update(T model)
        {
            _context.Update(model);
            _context.SaveChanges();

            return model;
        }
        public async Task RemoveAsync(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public T Remove(T model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return model;
        }
        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public OrderProduct GetOrderById(int orderId)
        {
            // Implement logic to retrieve an order by its ID, including associated products
            return _context.OrderProducts.Include(o => o.Product).FirstOrDefault(o => o.Id == orderId);
        }
    }
}
