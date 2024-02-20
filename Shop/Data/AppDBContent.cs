using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDBContent : DbContext
    {
        //Базовый конструктор по умолчанию, для работы с БД
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        { 
            
        }

        //РЕгуистрируем таблички 
        //Устанавливает товары 
        public  DbSet<Car> Car { get; set; }

        //Устанавливает категории
        public DbSet<Category> Category { get; set; }

        //Устанавливает товары в корзине
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> orderDetail { get; set; }
    }
}
