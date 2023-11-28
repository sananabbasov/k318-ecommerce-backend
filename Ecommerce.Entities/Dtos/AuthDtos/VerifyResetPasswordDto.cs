using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Dtos.AuthDtos;

public class VerifyResetPasswordDto
{
    public string Token { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RepeatPassword { get; set; }
}
