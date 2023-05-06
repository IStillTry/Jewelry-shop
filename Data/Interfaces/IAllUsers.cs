using Jewelry_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Jewelry_shop.Data.Interfaces
{
    public interface IAllUsers
    {
        User getLoginUser(string Login); /*авторизація користувача*/

        User createUser(User user); 

        User getLoginPasswordUser(string Login, string Password); /*реєстрація користувача*/

        public ClaimsIdentity Authenticate(User user); /*аутентифікація користувача*/
    }
}
