using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Utilities.Security.Hashing;
using NUnit.Framework;

namespace Ecommerce.Testing;

public class PasswordTests
{

    [Test]
    public void CheckUserPassword()
    {
        byte[] passwordHash, passwordSalt;
        PasswordHashing.HashPassword("12345", out passwordHash, out passwordSalt);

        var data = PasswordHashing.VerifyPassword("12345", passwordHash, passwordSalt);
        Assert.True(data);
    }


    [Test]
    public void CheckUserWrongPassword()
    {
        byte[] passwordHash, passwordSalt;
        PasswordHashing.HashPassword("12345", out passwordHash, out passwordSalt);

        var data = PasswordHashing.VerifyPassword("123457", passwordHash, passwordSalt);
        Assert.False(data);
    }
}