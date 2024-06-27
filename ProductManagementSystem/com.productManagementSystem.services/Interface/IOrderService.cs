using com.productManagementSystem.DBEntity.ViewModels;

namespace com.productManagementSystem.services.Interface
{
    public interface IOrderService
    {
        public List<OrderModel> GetAll();
        public Task<bool> CreateOrder(CreateOrderModelDto addorder);
        public OrderModel GetById(int Id);
        public Task<bool> UpdateOrder(int Id, UpdateOrderModelDto omd);
        public Task<bool> DeleteOrder(int Id);
    }
}
