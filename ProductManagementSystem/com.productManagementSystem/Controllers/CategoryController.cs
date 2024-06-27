using com.productManagementSystem.DBEntity.ViewModels;
using com.productManagementSystem.services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace com.productManagementSystem.Controllers
{
    [Route("api/CategoryController")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Configuration
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion Configuration

        #region Category_GetAll
        [HttpGet("Get_Categories")]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }
        #endregion Category_GetAll

        #region Category_CreateCategory
        [HttpPost("Add_Category")]
        public async Task<IActionResult> CreateCategory(CreateCategoryModelDto cmd)
        {
            bool cc = await _categoryService.CreateCategory(cmd);
            return Ok(cc);
        }
        #endregion Category_CreateCategory

        #region Category_GetById
        [HttpGet("GetById/{Id:int}")]
        public IActionResult GetById(int Id)
        {
            var categories = _categoryService.GetById(Id);
            return Ok(categories);
        }
        #endregion Category_GetById

        #region Category_UpdateCategory
        [HttpPut("Edit_Category/{Id:int}")]
        public IActionResult UpdateCategory(int Id, UpdateCategoryModelDto cmd)
        {
            var categories = _categoryService.UpdateCategory(Id, cmd);
            return Ok();
        }
        #endregion Category_UpdateCategory

        #region Category_DeleteCategory
        [HttpDelete("Delete_Category/{Id:int}")]
        public async Task<IActionResult> DeleteCategory(int Id)
        {
            bool cd = await _categoryService.DeleteCategory(Id);
            return Ok();
        }
        #endregion Category_DeleteCategory
    }
}
