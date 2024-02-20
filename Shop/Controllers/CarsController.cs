using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        // Обращаемся к функции, которая возвращает результат ввиде эштмл страницы. Передаем обект с товарами ей
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        //Конструктор чтобы записать данные в переменные. На основе ин. IAllCars
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
                cars = _allCars.Cars.OrderBy(i => i.Id);
            else
            {
                if (string.Equals("электромобили", category))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
                else
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                    currCategory = "Классические автомобили";
                }
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                carrCategory = currCategory
            };

            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);

        }
    }
}
