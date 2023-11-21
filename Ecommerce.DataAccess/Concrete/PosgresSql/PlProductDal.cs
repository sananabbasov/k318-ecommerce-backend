using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Ecommerce.Core.DataAccess.EntityFramework.Concrete;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.DataAccess.Concrete.EntityFramework;
using Ecommerce.Entities.Concrete;

namespace Ecommerce.DataAccess.Concrete.PosgresSql;

public class PlProductDal : IProductDal
{
    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}
