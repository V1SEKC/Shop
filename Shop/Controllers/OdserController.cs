using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allorders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allorders, ShopCart shopCart)
        {
            this.allorders = allorders;
            this.shopCart = shopCart;
        }

        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost ]
		public ActionResult Checkout(Order order)
		{
            shopCart.ListShopCartItem = shopCart.getShopItems();
            if (shopCart.ListShopCartItem.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары");
            }

            if (ModelState.IsValid)
            {
                allorders.createOrder(order);
                return RedirectToAction("Complete");
            }

			return View(order);  //Возвращаем вместе с обектом, поэтому у нас не проподает форма
		}

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
	}
}
