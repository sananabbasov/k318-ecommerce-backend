using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.Dtos.CategoryDtos;

namespace Ecommerce.Business.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category,CategoryCreateDto>().ReverseMap();
    }
}
