using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class ShopCartControllers : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartControllers(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        //Отображения корзины 
        public ViewResult Index() //Возвращает шаблон стр
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopCartItem = items;  //Устанавливаем все товары которые есть в карзине

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        //Переодресовывет нас на новую стр, добовляя товары в карзину
        public RedirectToActionResult addToCart(int id)
        {
            Car item = _carRep.Cars.FirstOrDefault(i => i.Id == id);//Добовляение товара у которого айди совподает
            if (item != null)
                _shopCart.AddToCart(item);
            return RedirectToAction("Index");
        }
    }
}
