using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using System.Collections.Generic;

namespace Jewelry_shop.Data.Repository
{
    public class CategoryRepository : IJewelryCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
