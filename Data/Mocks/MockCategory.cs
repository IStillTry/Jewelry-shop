using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using System.Collections.Generic;

namespace Jewelry_shop.Data.Mocks
{
    public class MockCategory : IJewelryCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get { 
              return new List<Category> { 
                  new Category{ NameCategory = "Каблучка"},
                  new Category{ NameCategory = "Обручка"},
                  new Category{ NameCategory = "Сережки"},
                  new Category{ NameCategory = "Браслет"}
              };
            }
        }
    }
}
