
using com.productManagementSystem.DBEntity.DataModels;

namespace com.productManagementSystem.DBEntity.ViewModels
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class CreateOrderModelDto
    {
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get;set; }
    }

    public class UpdateOrderModelDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? ModifiedDate { get; set;}
        public List<Product>? Products { get; set; }
    }
}
