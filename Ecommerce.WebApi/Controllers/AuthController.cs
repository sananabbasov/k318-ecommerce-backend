using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Business.Abstract;
using Ecommerce.Entities.Dtos.AuthDtos;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult RegisterUser([FromBody] RegisterDto registerDto)
    {
        var user = _authService.Register(registerDto);

        if (user.Success)
        {
            return Ok(user);
        }

        return BadRequest(user);
    }
}
