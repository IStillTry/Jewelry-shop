using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Jewelry_shop.Helper
{
    public static class HashPasswordHelper
    {
        public static string HashPassword(string password) 
        {
            using (var sha256 = SHA256.Create()) 
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return hash;
            }
        }
    }
}
