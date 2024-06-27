using com.productManagementSystem.DBEntity.DataModels;
using com.productManagementSystem.DBEntity.ViewModels;
using com.productManagementSystem.generic.repositories.Interface;
using com.productManagementSystem.services.Interface;

namespace com.productManagementSystem.services
{
    public class SuppliersService : ISuppliersService
    {
        #region Configuration
        private readonly IGenericRepositories<Supplier> _supplierRepository;
        public SuppliersService(IGenericRepositories<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        #endregion Configuration

        #region Supplier_GetAll
        public List<SupplierModel> GetAll()
        {
            var supplier = _supplierRepository.GetAll().Select(c => new SupplierModel
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                ContactNumber = c.ContactNumber,
                Address = c.Address,
                City = c.City,
                CreatedDate = (DateTime)c.CreatedDate
            }).ToList();
            return supplier;
        }
        #endregion Supplier_GetAll

        #region Supplier_CreateSupplier
        public async Task<bool> CreateSupplier(CreateSupplierModelDto supplier)
        {
            Supplier sDto = new()
            {
                FirstName = supplier.FirstName,
                LastName = supplier.LastName,
                ContactNumber = supplier.ContactNumber,
                Address = supplier.Address,
                City = supplier.City,
                CreatedDate = DateTime.Now,
            };
            _supplierRepository.Add(sDto);
            return true;
        }
        #endregion Supplier_CreateSupplier

        #region Supplier_GetById
        public SupplierModel GetById(int Id)
        {
            var supplier = _supplierRepository.GetAll().FirstOrDefault(e => e.Id == Id);
            SupplierModel cm = new()
            {
                Id = supplier.Id,
                FirstName = supplier.FirstName,
                LastName = supplier.LastName,
                ContactNumber = supplier.ContactNumber,
                Address = supplier.Address,
                City = supplier.City,
                CreatedDate = (DateTime)supplier.CreatedDate
            };
            return cm;
        }
        #endregion Supplier_GetById

        #region Supplier_UpdateSupplier
        public async Task<bool> UpdateSupplier(int Id, UpdateSupplierModelDto supplier)
        {
            var uDto = _supplierRepository.GetAll().FirstOrDefault(e => e.Id == Id);
            if (uDto == null)
            {
                return false;
            }
            else
            {
                uDto.FirstName = supplier.FirstName;
                uDto.LastName = supplier.LastName;
                uDto.ContactNumber = supplier.ContactNumber;
                uDto.Address = supplier.Address;
                uDto.City = supplier.City;
                uDto.ModifiedDate = DateTime.Now;
                _supplierRepository.Update(uDto);
            }
            return true;
        }
        #endregion Supplier_UpdateSupplier

        #region Supplier_DeleteSupplier
        public async Task<bool> DeleteSupplier(int Id)
        {
            var supplier = _supplierRepository.GetAll().FirstOrDefault(e => e.Id == Id);
            if (supplier == null)
            {
                return false;
            }
            else
            {
                _supplierRepository.Remove(supplier);
            }
            return true;
        }
        #endregion Supplier_DeleteSupplier
    }
}
