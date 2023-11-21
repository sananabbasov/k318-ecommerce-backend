using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Entities.Abstract;

namespace Ecommerce.Core.Entities.Concrete;

public class Role : IEntity
{
    public int Id { get; set; }
    public string RoleName { get; set; }
}
