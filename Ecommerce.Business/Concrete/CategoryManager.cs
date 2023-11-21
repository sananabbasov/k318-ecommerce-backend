using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.Dtos.CategoryDtos;

namespace Ecommerce.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    private readonly IMapper _mapper;

    public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
    }

    public void CreateCategory(CategoryCreateDto categoryCreate)
    {
        var map = _mapper.Map<Category>(categoryCreate);
        _categoryDal.Add(map);
    }


    public List<CategoryHomeDto> GetHomeCategories()
    {
        throw new NotImplementedException();
    }
}
