using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Jewelry_shop.Data.Mocks
{
    public class MockJewelryItems : IAllJewelryItems
    {
        private readonly IJewelryCategory _categoryJewelryItem = new MockCategory();
        public IEnumerable<JewelryItem> JewelryItems
        {
            get {
                return new List<JewelryItem> {
             new JewelryItem{
                 Name = "Все заради кохання", 
                 Img = "/img/1.png", 
                 Price = 1500, 
                 IsFavorite = true, 
                 Available = true, 
                 Category = _categoryJewelryItem.AllCategories.First()
                },
             new JewelryItem{
                 Name = "Небесні зорі", 
                 Img = "/img/2.png", 
                 Price = 1800, 
                 IsFavorite = true, 
                 Available = true,
                 Category = _categoryJewelryItem.AllCategories.First()
                },
             new JewelryItem{
                 Name = "Блискуча хвиля", 
                 Img = "/img/3.png", 
                 Price = 2000, 
                 IsFavorite = true, 
                 Available = true, 
                 Category = _categoryJewelryItem.AllCategories.First()
                },
             new JewelryItem{
                 Name = "Дзвіночок",
                 Img = "/img/4.png",
                 Price = 2000,
                 IsFavorite = true,
                 Available = true,
                 Category = _categoryJewelryItem.AllCategories.Last()
                }
                };
            }
        }
        public IEnumerable<JewelryItem> GetFavJewelryItems { get ; set; }

        public JewelryItem GetJewelryItem(int jewelryItemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
