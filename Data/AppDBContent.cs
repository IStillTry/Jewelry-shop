using Jewelry_shop.Data.Models;
using Microsoft.EntityFrameworkCore; 
namespace Jewelry_shop.Data
{
    public class AppDBContent : DbContext {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { 
        
        }   

        public DbSet<JewelryItem> JewelryItem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem{ get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<User> User { get; set; }


    }
}
