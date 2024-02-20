using Microsoft.Identity.Client.Extensibility;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrderRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void  createOrder(Order order)
        {
            //throw void NotImplementedException(); 
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.ListShopCartItem;  //Получаем товары и записываем в переменную

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = el.car.Id,  //
                    orderID = order.Id, 
                    price = el.car.Price
                };
                
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
