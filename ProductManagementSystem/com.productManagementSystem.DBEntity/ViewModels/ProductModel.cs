namespace com.productManagementSystem.DBEntity.ViewModels
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string SupplierName { get; set; }
        public int SupplierId { get; set; }
        public int InStock { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class CreateProductModelDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UpdateProductModelDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
