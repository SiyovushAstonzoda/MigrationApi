using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace MigrationApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<List<Category>> GetCategories()
    {
        return await _categoryService.GetCategories();
    }

    [HttpPost]
    public async Task<Category> AddCategory(Category category)
    {
        return await _categoryService.AddCategory(category);
    }

    [HttpPut]
    public async Task<Response<Category>> UpdateCategory(Category category)
    {
        return await _categoryService.UpdateCategory(category);
    }

    [HttpDelete]
    public async Task<Response<string>> DeleteCategory(int id)
    {
        return await _categoryService.DeleteCategory(id);
    }
}
