using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_shop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int JewelryItemID { get; set; }
        public uint Price { get; set; }
        public virtual JewelryItem JewelryItem { get; set; }
        public virtual Order Order { get; set; }

    }
}
