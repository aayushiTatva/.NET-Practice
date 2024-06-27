using com.productManagementSystem.DBEntity.ViewModels;

namespace com.productManagementSystem.services.Interface
{
    public interface ICategoryService
    {
        public List<CategoryModel> GetAll();
        public Task<bool> CreateCategory(CreateCategoryModelDto category);
        public CategoryModel GetById(int Id);
        public Task<bool> UpdateCategory(int Id, UpdateCategoryModelDto category);
        public Task<bool> DeleteCategory(int Id);
    }
}
