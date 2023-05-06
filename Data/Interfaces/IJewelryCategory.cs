using Jewelry_shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Jewelry_shop.Data.Interfaces
{
    public interface IJewelryCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
