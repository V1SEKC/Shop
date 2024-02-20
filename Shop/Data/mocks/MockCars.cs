using System.Xml.Linq;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();  //К какой категории принадлежит конкретный обект

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {   name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        img = "/img/Тесла.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   name = "Ford Mystang",
                        shortDesc = "Агрессивный и спортивый",
                        longDesc = "Агрессивный внешний вид, точно произведет впечетление",
                        img = "/img/Мустанг.jpg",
                        price = 30000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   name = "BMW M4",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        img = "/img/БМВ.jpeg",
                        price = 60000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   name = "BMW I8",
                        shortDesc = "Быстрая и невероятная",
                        longDesc = "Шикарный внешний вид, и дизайн будущего",
                        img = "/img/I8.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   name = "Porsche Boxster",
                        shortDesc = "Красивый и аккуратный",
                        longDesc = "Точно привлечет внимание на улицах города",
                        img = "/img/Порш.jpg",
                        price = 50000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   name = "Land Rover Range Rover",
                        shortDesc = "Дорогой и впечетляющий",
                        longDesc = "Автомобиль сразу произвелет впечетление на окружение",
                        img = "/img/Ровер.jpg",
                        price = 30000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjestCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
