using Ecommerce.Core.Entities.Abstract;

namespace Ecommerce.Entities.Concrete;

public class Category : BaseEntity, IEntity
{
   
    public string CategoryName { get; set; }
    public string SeoUrl { get; set; }
    public string Description { get; set; }
}
