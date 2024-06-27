using com.productManagementSystem.DBEntity.ViewModels;

namespace com.productManagementSystem.services.Interface
{
    public interface ISuppliersService
    {
        public List<SupplierModel> GetAll();
        public Task<bool> CreateSupplier(CreateSupplierModelDto supplier);
        public SupplierModel GetById(int Id);
        public Task<bool> UpdateSupplier(int Id, UpdateSupplierModelDto supplier);
        public Task<bool> DeleteSupplier(int Id);
    }
}
