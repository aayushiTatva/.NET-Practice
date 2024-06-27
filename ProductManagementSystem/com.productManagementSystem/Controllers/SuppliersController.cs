using com.productManagementSystem.DBEntity.DataContext;
using com.productManagementSystem.DBEntity.ViewModels;
using com.productManagementSystem.services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace com.productManagementSystem.Controllers
{
    [Route("api/SuppliersController")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        #region Configuration
        private readonly ISuppliersService _suppliersService;
        public SuppliersController(ISuppliersService supplierService)
        {
            _suppliersService = supplierService;
        }
        #endregion Configuration

        #region Suppliers_GetAll
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var suppliers = _suppliersService.GetAll();
            return Ok(suppliers);
        }
        #endregion Suppliers_GetAll

        #region Suppliers_CreateSupplier
        [HttpPost("Add_Supplier")]
        public async Task<IActionResult> CreateSupplier(CreateSupplierModelDto cmd)
        {
            bool cc = await _suppliersService.CreateSupplier(cmd);
            return Ok(cc);
        }
        #endregion Suppliers_CreateSupplier

        #region Suppliers_GetById
        [HttpGet("GetById/{Id:int}")]
        public IActionResult GetById(int Id)
        {
            var suppliers = _suppliersService.GetById(Id);
            return Ok(suppliers);
        }
        #endregion Suppliers_GetById

        #region Suppliers_UpdateSupplier
        [HttpPut("Edit_Supplier/{Id:int}")]
        public IActionResult UpdateSupplier(int Id, UpdateSupplierModelDto cmd)
        {
            var suppliers = _suppliersService.UpdateSupplier(Id, cmd);
            return Ok();
        }
        #endregion Suppliers_UpdateSupplier

        #region Suppliers_DeleteSupplier
        [HttpDelete("Delete_Supplier/{Id:int}")]
        public async Task<IActionResult> DeleteSupplier(int Id)
        {
            bool cd = await _suppliersService.DeleteSupplier(Id);
            return Ok();
        }
        #endregion Suppliers_DeleteSupplier
    }
}
