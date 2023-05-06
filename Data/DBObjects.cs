using Jewelry_shop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace Jewelry_shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.JewelryItem.Any())
            {
                content.AddRange(
                 new JewelryItem
                 {
                 Name = "Все заради кохання",
                 Img = "/img/1.png",
                 Price = 1500,
                 IsFavorite = true,
                 Available = true,
                 Category = Categories["Каблучка"]
                 },
                 new JewelryItem
                 {
                     Name = "Небесні зорі",
                     Img = "/img/2.png",
                     Price = 1800,
                     IsFavorite = true,
                     Available = true,
                     Category = Categories["Каблучка"]
                 },
                 new JewelryItem
                 {
                     Name = "Блискуча хвиля",
                     Img = "/img/3.png",
                     Price = 2000,
                     IsFavorite = true,
                     Available = true,
                     Category = Categories["Каблучка"]
                 },
                 new JewelryItem
                 {
                     Name = "Дзвіночок",
                     Img = "/img/4.png",
                     Price = 2000,
                     IsFavorite = true,
                     Available = true,
                     Category = Categories["Браслет"]
                 }
                 );
            }
            content.SaveChanges();
        }
            private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get { 
            if (category == null)
                {
                    var list = new Category[] {
                    new Category{ NameCategory = "Каблучка"},
                    new Category{ NameCategory = "Обручка"},
                    new Category{ NameCategory = "Сережки"},
                    new Category{ NameCategory = "Браслет"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list) category.Add(el.NameCategory, el);
                }
              return category;
            }
        }
    }
}
