using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_shop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public JewelryItem JewelryItem { get; set; }
        public int Price { get; set; }
        public string ShopCartId { get; set; }


    }
}
