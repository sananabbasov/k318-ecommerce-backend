using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Entities.Abstract;

namespace Ecommerce.Core.Entities.Concrete;

public class BaseUser 
{
    public int Id { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public bool EmailConfirmed { get; set; }
    public string ConfirmationToken { get; set; }
    public int LoginAttempt { get; set; }
    public DateTime DeactiveTime { get; set; }
    public bool IsDeactive { get; set; }
}
