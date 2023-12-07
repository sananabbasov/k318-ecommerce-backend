using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.DataAccess.EntityFramework.Concrete;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess.Concrete.EntityFramework;

public class EfUserDal : EfRepositoryBase<User, AppDbContext>, IUserDal
{
    public User GetUserByEmail(string email)
    {
        // Error burda idi.
        using var context = new AppDbContext();
        return context.Users.FirstOrDefault(u => u.Email == email);
    }
}
