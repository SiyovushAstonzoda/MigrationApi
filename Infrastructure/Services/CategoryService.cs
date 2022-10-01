using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Context;
using Infrastructure.Interfaces;
namespace Infrastructure.Services;

public class CategoryService : ICategoryService
{
    private readonly DataContext _context;
    public CategoryService(DataContext context)
    {
        _context = context;
    }

    public async Task<Category> AddCategory(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChangesAsync();
        return category;
    }

    public async Task<List<Category>> GetCategories()
    {
        return _context.Categories.ToList();
    }

    public async Task<Response<Category>> UpdateCategory(Category category)
    {
        var record = await _context.Categories.FindAsync(category.Id);
        //if not found it will return null
        if(record == null) return new Response<Category>(System.Net.HttpStatusCode.NotFound, "No record found");

        record.Name = category.Name;
        await _context.SaveChangesAsync();

        return new Response<Category>(record);
    }

    public async Task<Response<string>> DeleteCategory(int Id)
    {
         var record = await _context.Categories.FindAsync(Id);

         if(record == null) return new Response<string>(System.Net.HttpStatusCode.NotFound, "Not found");

         _context.Categories.Remove(record);
         await _context.SaveChangesAsync();
         return new Response<string>("success");

    }
}
