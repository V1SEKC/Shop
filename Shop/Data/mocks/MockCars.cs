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
                    {   Name = "Tesla Model S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        Img = "/img/Тесла.jpg",
                        Price = 45000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   Name = "Ford Mystang",
                        ShortDesc = "Агрессивный и спортивый",
                        LongDesc = "Агрессивный внешний вид, точно произведет впечетление",
                        Img = "/img/Мустанг.jpg",
                        Price = 30000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   Name = "BMW M4",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        Img = "/img/БМВ.jpeg",
                        Price = 60000,
                        IsFavourite = false,
                        Available = false,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   Name = "BMW I8",
                        ShortDesc = "Быстрая и невероятная",
                        LongDesc = "Шикарный внешний вид, и дизайн будущего",
                        Img = "/img/I8.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   Name = "Porsche Boxster",
                        ShortDesc = "Красивый и аккуратный",
                        LongDesc = "Точно привлечет внимание на улицах города",
                        Img = "/img/Порш.jpg",
                        Price = 50000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },


                    new Car
                    {   Name = "Land Rover Range Rover",
                        ShortDesc = "Дорогой и впечетляющий",
                        LongDesc = "Автомобиль сразу произвелет впечетление на окружение",
                        Img = "/img/Ровер.jpg",
                        Price = 30000,
                        IsFavourite = false,
                        Available = false,
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
