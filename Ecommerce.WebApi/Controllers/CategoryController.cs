using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Business.Abstract;
using Ecommerce.Entities.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    
    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody]CategoryCreateDto addCategoryDto)
    {
       var res =  _categoryService.CreateCategory(addCategoryDto);
        return Ok(res);
    }
}
