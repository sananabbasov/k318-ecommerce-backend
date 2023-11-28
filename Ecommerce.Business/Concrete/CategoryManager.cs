using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Business.Abstract;
using Ecommerce.Core.Utilities.Results.Abstract;
using Ecommerce.Core.Utilities.Results.Concrete.ErrorResults;
using Ecommerce.Core.Utilities.Results.Concrete.SuccessResults;
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

    public IResult CreateCategory(CategoryCreateDto categoryCreate)
    {
        try
        {
            var map = _mapper.Map<Category>(categoryCreate);
            map.SeoUrl = "telefonlar";
            map.CreatedDate = DateTime.Now;
            _categoryDal.Add(map);
            return new SuccessResult("Elave olundu");
        }
        catch (Exception e)
        {
            return new ErrorResult(e.Message.ToString());
        }
    }


    public IDataResult<List<CategoryHomeDto>> GetHomeCategories()
    {
        return new SuccessDataResult<List<CategoryHomeDto>>(null, "elave olundu");
    }
}
