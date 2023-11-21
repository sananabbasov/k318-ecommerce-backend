using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;

namespace Ecommerce.Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

   
}
