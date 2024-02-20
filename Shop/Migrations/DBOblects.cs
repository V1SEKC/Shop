using Shop.Data;
using Shop.Data.Models;

namespace Shop.Migrations
{
    public class DBOblects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())  //Получаем все обекты если их нету, то добовляем
                content.Category.AddRange(Categories.Select(c => c.Value));  //Позволяет добавить несколь обектов сразу, взять их значение и вывести

            //Добовляем обекты товаров
            if (!content.Car.Any())
            {
                content.AddRange(

                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        img = "/img/Тесла.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Электромобили"]  //Указываем ключ необходимого элемента
                    },


                    new Car
                    {
                        name = "Ford Mystang",
                        shortDesc = "Агрессивный и спортивый",
                        longDesc = "Агрессивный внешний вид, точно произведет впечетление",
                        img = "/img/Мустанг.jpg",
                        price = 30000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },


                    new Car
                    {
                        name = "BMW M4",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        img = "/img/БМВ.jpeg",
                        price = 60000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },


                    new Car
                    {
                        name = "BMW I8",
                        shortDesc = "Быстрая и невероятная",
                        longDesc = "Шикарный внешний вид, и дизайн будущего",
                        img = "/img/I8.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },


                    new Car
                    {
                        name = "Porsche Boxster",
                        shortDesc = "Красивый и аккуратный",
                        longDesc = "Точно привлечет внимание на улицах города",
                        img = "/img/Порш.jpg",
                        price = 50000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },


                    new Car
                    {
                        name = "Land Rover Range Rover",
                        shortDesc = "Дорогой и впечетляющий",
                        longDesc = "Автомобиль сразу произвелет впечетление на окружение",
                        img = "/img/Ровер.jpg",
                        price = 30000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    }

                );
            }

            content.SaveChanges();

        }


        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories  //Возвращаем словарь, в который передаем клчи и значение элементов
        {
            get
            {
                if (category == null)
                {
                    //Добовляем новые обекты
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид странспорта" },
                        new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();  //Добовляем элементы моссива в нее

                    foreach (Category el in list)
                        category.Add(el.categoryName, el);   //Добовляем новый обект          
                }

                return category;
            }
        }

    }
}
