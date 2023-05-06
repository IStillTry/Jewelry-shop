using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Jewelry_shop.Data.Repository
{
    public class JewelryItemRepository : IAllJewelryItems
    {
        private readonly AppDBContent appDBContent;

        public JewelryItemRepository(AppDBContent appDBContent) { 
        this.appDBContent = appDBContent;
        }


        public IEnumerable<JewelryItem> JewelryItems => appDBContent.JewelryItem.Include(c => c.Category);

        public IEnumerable<JewelryItem> GetFavJewelryItems => appDBContent.JewelryItem.Where(p => p.IsFavorite).Include(c => c.Category);

        public JewelryItem GetJewelryItem(int jewelryItemId) => appDBContent.JewelryItem.FirstOrDefault(p => p.Id == jewelryItemId);
    }
}
