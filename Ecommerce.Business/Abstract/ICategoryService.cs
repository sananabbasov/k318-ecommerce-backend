using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.Dtos.CategoryDtos;

namespace Ecommerce.Business.Abstract;

public interface ICategoryService
{
    void CreateCategory(CategoryCreateDto categoryCreate);
    List<CategoryHomeDto> GetHomeCategories();
}
