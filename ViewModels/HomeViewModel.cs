using Jewelry_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<JewelryItem> favJewelryItems { get; set; }
    }
}
