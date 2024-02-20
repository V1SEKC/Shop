using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        //Чтобы могли рабоать с БД
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent) //Задаем значение переменной выше
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }

        public List<ShopCartItem> ListShopCartItem { get; set; }

        public static ShopCart GetCart(IServiceProvider service)    //Проверка на существование товара в корзине 
        { 
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string ShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();  //Проверка на сущестование, если такого нету, тогда создаем новый 

            session.SetString("CartId", ShopCartId);

            return new ShopCart(context) { ShopCartId = ShopCartId };
        }

        //Добовляем товары в карзину 
        public void AddToCart(Car car)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCatId = ShopCartId,
                car = car,
                price = car.Price
            });
            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        { 
            return appDBContent.ShopCartItem.Where(c => c.ShopCatId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
