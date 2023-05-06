using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using Jewelry_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_shop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllJewelryItems _jewelryItemRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllJewelryItems JewelryItemRep, ShopCart ShopCart) {
            _jewelryItemRep = JewelryItemRep;
            _shopCart = ShopCart;        
        }

        public ViewResult Index() {
            var items = _shopCart.getShopCartItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int Id) {
            var item = _jewelryItemRep.JewelryItems.FirstOrDefault(i => i.Id == Id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }


    }
}
