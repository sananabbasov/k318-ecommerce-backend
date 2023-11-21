using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Entities.Abstract;

namespace Ecommerce.Entities.Concrete;

public class Affiliate : BaseEntity, IEntity
{
    public string? AffiliateUrl { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }
    public decimal Percent { get; set; }
    public int? ProductId { get; set; }
    public Product? Product { get; set; }
}
