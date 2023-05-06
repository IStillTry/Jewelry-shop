using Jewelry_shop.Data.Models;
using System.Collections;
using System.Web.Razor.Generator;
using System.Collections.Generic;

namespace Jewelry_shop.ViewModels
{
    public class JewelryItemsListViewModel
    {
        public IEnumerable<JewelryItem> AllJewelryItems { get; set;}
        public string CurrCategory { get; set;}
    }
}
