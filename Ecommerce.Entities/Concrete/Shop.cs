using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete;

public class Shop : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; }    
    public string BannerUrl { get; set; }
    public string PhotoUrl { get; set; }
    public bool IsVerified { get; set; }
    public List<Follower> Followers { get; set; }
    public List<Advertisement> Advertisements { get; set; }
}
