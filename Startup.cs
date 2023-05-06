using Jewelry_shop.Data;
using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Jewelry_shop.Data.Repository;
using Jewelry_shop.Data.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Web;

namespace Jewelry_shop
{
    public class Startup
    {

        private IConfigurationRoot _confString; /*змінна для створення конекшену з БД*/
       
        public Startup (Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv) {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build(); /* встановлення конекшену з БД*/
        }

        /*This method gets called by the runtime. Use this method to add services to the container.
        For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940 */
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllJewelryItems, JewelryItemRepository>();
            services.AddTransient<IJewelryCategory,CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();
            services.AddTransient<IAllUsers, UserRepository>();

            /*services.AddTransient<IAllJewelryItems, MockJewerlyItems>();
            services.AddTransient<IJewelryCategory, MockCategory>();*/

            services.AddMvc(mvcOptions => {
                mvcOptions.EnableEndpointRouting = false;
            }); 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.getCart(sp)); /*Отримання кошику користувача*/

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => options.LoginPath = "/Account/Login"); /* автентифікація методом Cookie з перекидуванням неавторизованих користувачів до авторизації */
            services.AddAuthorization(); /* авторизація методом Cookie */

            services.AddMemoryCache();
            services.AddSession();
        }

        /*This method gets called by the runtime. Use this method to configure the HTTP request pipeline.*/
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseAuthentication(); /* додавання middleware автентифікації */
            app.UseAuthorization();  /* додавання middleware авторизації */
            app.UseHttpsRedirection();

            app.UseSession();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();

            using (var scope = app.ApplicationServices.CreateScope()) 
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>(); /* додавання БД */
                DBObjects.Initial(content);
            }
        }
    }
}
