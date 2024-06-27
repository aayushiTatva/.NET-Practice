using com.productManagementSystem.DBEntity.ViewModels;

namespace com.productManagementSystem.services.Interface
{
    public interface IProductService
    {
        public List<ProductModel> GetAll();
        public Task<bool> CreateProduct(CreateProductModelDto product);
        public ProductModel GetById(int Id);
        public Task<bool> UpdateProduct(int Id, UpdateProductModelDto supplier);
        public Task<bool> DeleteProduct(int Id);
    }
}
