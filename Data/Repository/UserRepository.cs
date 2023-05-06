using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Jewelry_shop.Data.Repository
{
    public class UserRepository : IAllUsers
    {
        private readonly AppDBContent appDBContent;

        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public ClaimsIdentity Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim (ClaimsIdentity.DefaultNameClaimType,user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            return new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,ClaimsIdentity.DefaultRoleClaimType);
        }

        public User createUser(User user)
        {
            appDBContent.User.Add(user);
            appDBContent.SaveChanges();
            return user;
        }

        public User getLoginPasswordUser(string Login, string Password) => appDBContent.User.FirstOrDefault(p => p.Login.Equals(Login) && p.Password.Equals(Password));

        public User getLoginUser(string Login) => appDBContent.User.FirstOrDefault(p => p.Login.Equals(Login)); /*Отримання користувача для перевірки Логіну */

    }
}
