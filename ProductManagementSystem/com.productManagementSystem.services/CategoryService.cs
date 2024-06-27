using com.productManagementSystem.DBEntity.DataModels;
using com.productManagementSystem.DBEntity.ViewModels;
using com.productManagementSystem.generic.repositories.Interface;
using com.productManagementSystem.services.Interface;

namespace com.productManagementSystem.services
{
    public class CategoryService : ICategoryService
    {
        #region Configuration
        private readonly IGenericRepositories<Category> _categoryRepository;
        public CategoryService(IGenericRepositories<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion Configuration

        #region Category_GetAll
        public List<CategoryModel> GetAll()
        {
            var categories = _categoryRepository.GetAll().Select(c => new CategoryModel{
                                                                         Id = c.Id,
                                                                         Name = c.Name,
                                                                         CreatedDate = (DateTime)c.CreatedDate
                                                                     }).ToList();
            return categories;
        }
        #endregion Category_GetAll

        #region Category_CreateCategory
        public async Task<bool> CreateCategory(CreateCategoryModelDto category)
        {
            Category cmDto = new ()
            {
                Name = category.Name,
                CreatedDate = DateTime.Now,
            };
            _categoryRepository.Add(cmDto);
            return true;
        }
        #endregion Category_CreateCategory

        #region Category_GetById
        public CategoryModel GetById(int Id)
        {
            var categories = _categoryRepository.GetAll().FirstOrDefault(e => e.Id == Id);
            CategoryModel cm = new()
            {
                Id = categories.Id,
                Name = categories.Name
            };
            return cm;
        }
        #endregion Category_GetById

        #region Category_UpdateCategory
        public async Task<bool> UpdateCategory(int Id, UpdateCategoryModelDto category)
        {
            var categories = _categoryRepository.GetAll().FirstOrDefault(e => e.Id == Id);
            if(categories == null)
            {
                return false;
            }
            else
            {
                categories.Name = category.Name;
                categories.ModifiedDate = DateTime.Now;
                _categoryRepository.Update(categories);
            }
            return true;
        }
        #endregion Category_UpdateCategory

        #region Category_DeleteCategory
        public async Task<bool> DeleteCategory(int Id)
        {
            var categories = _categoryRepository.GetAll().FirstOrDefault(e => e.Id == Id);
            if(categories == null)
            {
                return false;
            }
            else
            {
                _categoryRepository.Remove(categories);
            }
            return true;
        }
        #endregion Category_DeleteCategory
    }
}
