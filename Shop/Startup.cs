using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.Migrations;

namespace Shop
{
    public class Startup
    {
        //Получаем данный из стр подключения БД
        private IConfigurationRoot _confString;

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            //Получение стр из файла джейсон
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //Какой SQL сервер берем, и какую переменную
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            //Интерфейсы реализуються в Repository
            services.AddTransient<IAllCars, CarRepository>(); //Обеденяет класс и интерфейс которой его реализует 
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();  //Сервер для сессий 
            services.AddScoped(sp => ShopCart.GetCart(sp));  //Если два пользователя зайдут на корзину, чтобы у них была разная корзина 

            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env) //Стереть серым
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Car/{action}/{category?}", defaults: new { Controller = "Car", action = "List" });
            });
            app.UseDeveloperExceptionPage();  //Страничка с ошибками 
            app.UseStatusCodePages(); //Коды стрниц 200, 400
            app.UseStaticFiles();    //Отображаем статические файлы картинки
            app.UseSession(); //Для приложения используем ссесии
            app.UseMvcWithDefaultRoute(); //Будет отображать файл по умолчанию

            //Чтобы добраться вне сервиса, из другой области AbandonedMutexException
            using (var scope = app.ApplicationServices.CreateScope())
            {
                //Подключаемся к AppDBContent
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();

                //Обращаемся к функции инишеал
                DBOblects.Initial(content);
            }
        }
    }  
}
