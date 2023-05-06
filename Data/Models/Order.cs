using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name ="Потрібно ввести Ваше ім'я")]
        [MaxLength(20, ErrorMessage = "Довжина імені повинна бути менш ніж 20 символів")]
        [MinLength(5, ErrorMessage = "Довжина імені повинна бути більш ніж 5 символів")]
        [Required(ErrorMessage = "Довжина імені повинна бути не менш ніж 5 символів")]
        public string Name { get; set; }

        [Display(Name = "Вкажіть Ваше прізвище")]
        [MaxLength(30, ErrorMessage = "Довжина прізвища повинна бути менш ніж 30 символів")]
        [MinLength(10, ErrorMessage = "Довжина прізвища повинна бути більш ніж 10 символів")]
        [Required(ErrorMessage = "Довжина прізвища повинна бути не менш ніж 10 символів")]
        public string Surname { get; set; }

        [Display(Name = "Вкажіть адресу")]
        [MaxLength(40, ErrorMessage = "Довжина адреси повинна бути менш ніж 40 символів")]
        [MinLength(10, ErrorMessage = "Довжина адреси повинна бути більш ніж 10 символів")]
        [Required(ErrorMessage = "Довжина адреси повинна бути не менш ніж 10 символів")]
        public string Address { get; set; }

        [Display(Name = "Вкажіть номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина номера повинна бути 10 символів")]
        public string Phone { get; set; }

        [Display(Name = "Вкажіть пошту")]
        [MaxLength(35, ErrorMessage = "Довжина email повинна бути менш ніж 35 символів")]
        [MinLength(10, ErrorMessage = "Довжина email повинна бути більш ніж 10 символів")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Довжина email повинна бути не менш ніж 10 символів")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)] /*не відображається в коді*/
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
