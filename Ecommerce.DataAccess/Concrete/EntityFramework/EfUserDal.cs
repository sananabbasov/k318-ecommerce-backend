using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.DataAccess.EntityFramework.Concrete;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;

namespace Ecommerce.DataAccess.Concrete.EntityFramework;

public class EfUserDal : EfRepositoryBase<User, AppDbContext>, IUserDal
{
    
}
