using Domain.Wrapper;
using Domain.Entities;
namespace Infrastructure.Interfaces;

public interface ICategoryService
{
    Task<List<Category>> GetCategories();
    Task<Category> AddCategory(Category category);
    Task<Response<Category>> UpdateCategory(Category category);
    Task<Response<string>> DeleteCategory(int Id);
}
