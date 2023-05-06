using Jewelry_shop.Data.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace Jewelry_shop.Data.Interfaces
{
    public interface IAllJewelryItems
    {
        IEnumerable<JewelryItem> JewelryItems { get; }
        IEnumerable<JewelryItem> GetFavJewelryItems { get;}
        JewelryItem GetJewelryItem(int jewelryItemId);
    }
}
