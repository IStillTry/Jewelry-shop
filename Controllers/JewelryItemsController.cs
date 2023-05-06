using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Jewelry_shop.Data.Controllers
{
    public class JewelryItemsController : Controller
    {

        private readonly IAllJewelryItems _allJewelryItems;
        private readonly IJewelryCategory _allCategories;

        public JewelryItemsController(IAllJewelryItems iallJewelryItems, IJewelryCategory ijewelryCategory)
        {
            _allJewelryItems = iallJewelryItems;
            _allCategories = ijewelryCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з прикрасами Jewelry Shop";
            JewelryItemsListViewModel obj = new JewelryItemsListViewModel();
            obj.AllJewelryItems = _allJewelryItems.JewelryItems;
            obj.CurrCategory = "Прикраси";
            return View(obj);
        }

        /*public ViewResult List()
        {
            var jewelryitems = _allJewelryItems.JewelryItems;
            return View(jewelryitems);
        }*/
    }
}
