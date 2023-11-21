using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Entities.Abstract;
using Ecommerce.Entities.Enums;

namespace Ecommerce.Entities.Concrete;

public class Advertisement : BaseEntity, IEntity
{
    public int ShopId { get; set; }
    public Shop Shop { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public string Text { get; set; }
    public string PhotoUrl { get; set; }
    public BannerSize BannerSize { get; set; }
}
