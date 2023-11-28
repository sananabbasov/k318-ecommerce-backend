using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Utilities.Security.Hashing;

public static class PasswordHashing
{
    public static void HashPassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hash = new HMACSHA512();
        passwordSalt = hash.Key;
        passwordHash = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    public static bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            // hskjfhksjdhfsdf  => wlkfwelkrjfmejrelqwrnwer => 123 => iewurewrwe => auspdofpsadjkcnafs
            using var hash = new HMACSHA512(passwordSalt);
            var hashedPassword = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < passwordHash.Length; i++)
            {
                if (passwordHash[i] != hashedPassword[i])
                {
                    return false;
                }
            }
            return true;
        }
}
