using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Jewelry_shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string shopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart getCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string ShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", ShopCartId);

            return new ShopCart(context) { shopCartId = ShopCartId };
        }

        public void AddToCart(JewelryItem jewelryItem) {
            appDBContent.ShopCartItem.Add(new ShopCartItem {
                ShopCartId = shopCartId,
                JewelryItem = jewelryItem,
                Price = jewelryItem.Price
            });

            appDBContent.SaveChanges();
        }


        public List<ShopCartItem> getShopCartItems() {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == shopCartId).Include(s => s.JewelryItem).ToList();
        }
    }
}
