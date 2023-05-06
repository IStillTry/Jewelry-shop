using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_shop.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Вкажіть логін")]
        [MaxLength(40, ErrorMessage = "Логін повинен мати довжину менш ніж 40 символів")]
        [MinLength(5, ErrorMessage = "Логін повинен мати довжину більше ніж 5 символів")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Вкажіть пароль")]
        [MinLength(5, ErrorMessage = "Пароль повинен мати довжину більше ніж 5 символів")]
        public string Password { get; set; }

    }
}
