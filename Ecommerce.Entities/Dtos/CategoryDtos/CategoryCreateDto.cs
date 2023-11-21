using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Dtos.CategoryDtos;

public class CategoryCreateDto
{
    public string CategoryName { get; set; }
    public string Description { get; set; }
}
