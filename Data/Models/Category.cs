using System.Collections.Generic;

namespace Jewelry_shop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public List<JewelryItem> JewelryItems { get; set; }
    }
}
