using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Business.Abstract;
using Ecommerce.Core.Utilities.Business;
using Ecommerce.Core.Utilities.Results.Abstract;
using Ecommerce.Core.Utilities.Results.Concrete.ErrorResults;
using Ecommerce.Core.Utilities.Results.Concrete.SuccessResults;
using Ecommerce.Core.Utilities.Security.Hashing;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Commands;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.Dtos.AuthDtos;
using MassTransit;

namespace Ecommerce.Business.Concrete;

public class AuthManager : IAuthService
{
    private readonly IUserDal _userDal;
    private readonly IMapper _mapper;
    private readonly IPublishEndpoint _publishEndpoint;

    public AuthManager(IUserDal userDal, IMapper mapper, IPublishEndpoint publishEndpoint)
    {
        _userDal = userDal;
        _mapper = mapper;
        _publishEndpoint = publishEndpoint;
    }

    public IDataResult<LoginUserDto> Login(LoginDto loginDto)
    {
        var userToCheck = BusinessRule.Run(
            CheckIsUserActive(loginDto),
            CheckUserPassword(loginDto)
            );

        if (!userToCheck.Success)
            return new ErrorDataResult<LoginUserDto>(null);




        return new SuccessDataResult<LoginUserDto>(null);
    }

    public IResult Register(RegisterDto registerDto)
    {
        var mapp = _mapper.Map<User>(registerDto);
        byte[] passwordHash, passwordSalt;
        PasswordHashing.HashPassword(registerDto.Password, out passwordHash, out passwordSalt);
        mapp.PasswordHash = passwordHash;
        mapp.PasswordSalt = passwordSalt;
        mapp.DeactiveTime = DateTime.Now;
        mapp.ConfirmationToken = Guid.NewGuid().ToString();

        SendEmailCommand sendEmail = new()
        {
            Email = "ehmed@compar.edu.az",
            Token = Guid.NewGuid().ToString(),
            FirstName = "Ehmed",
            LastName = "Ehmedli"
        };
        _publishEndpoint.Publish<SendEmailCommand>(sendEmail);
        _userDal.Add(mapp);
        return new SuccessResult();
    }

    public IResult ResetPassword(string email)
    {
        throw new NotImplementedException();
    }

    public IResult VerifyEmail(string token, string Email)
    {
        throw new NotImplementedException();
    }

    public IResult VerifyResetPassword(VerifyResetPasswordDto resetPasswordDto)
    {
        throw new NotImplementedException();
    }

    #region Business rules
    private IResult CheckIsUserActive(LoginDto loginDto)
    {
        var res = _userDal.Get(x => x.Email == loginDto.Email);
        if (res == null)
            return new ErrorResult();

        return new SuccessResult();
    }

    private IResult CheckUserPassword(LoginDto loginDto)
    {
        var res = _userDal.Get(x => x.Email == loginDto.Email);
        bool pass = PasswordHashing.VerifyPassword(loginDto.Password, res.PasswordHash, res.PasswordSalt);
        if (!pass)
            return new ErrorResult();

        return new SuccessResult();
    }
    #endregion

}
