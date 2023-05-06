using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using Jewelry_shop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllJewelryItems _jewelryItemRep;

        public HomeController(IAllJewelryItems JewelryItemRep)
        {
            _jewelryItemRep = JewelryItemRep;
        }


        [Authorize]
        public ViewResult Index() {
            var homeJewelryItems = new HomeViewModel
            {
                favJewelryItems = _jewelryItemRep.GetFavJewelryItems
            };

            return View(homeJewelryItems);
        }

    }
}
