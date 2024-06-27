namespace com.productManagementSystem.DBEntity.ViewModels
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class CreateCategoryModelDto
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UpdateCategoryModelDto
    {
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
