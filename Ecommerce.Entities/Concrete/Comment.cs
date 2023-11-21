using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Entities.Abstract;
using Ecommerce.Entities.Enums;

namespace Ecommerce.Entities.Concrete;

public class Comment : BaseEntity, IEntity
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public string Content { get; set; }
    public Review Review { get; set; }
    public virtual IEnumerable<CommentPhoto> CommentPhotos { get; set; }
}
