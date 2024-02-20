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
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        Img = "/img/Тесла.jpg",
                        Price = 45000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },


                    new Car
                    {
                        Name = "Ford Mystang",
                        ShortDesc = "Агрессивный и спортивый",
                        LongDesc = "Агрессивный внешний вид, точно произведет впечетление",
                        Img = "/img/Мустанг.jpg",
                        Price = 30000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },


                    new Car
                    {
                        Name = "BMW M4",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый и быстрый, и очень тихий автомобиль компании Tesla",
                        Img = "/img/БМВ.jpeg",
                        Price = 60000,
                        IsFavourite = false,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    },


                    new Car
                    {
                        Name = "BMW I8",
                        ShortDesc = "Быстрая и невероятная",
                        LongDesc = "Шикарный внешний вид, и дизайн будущего",
                        Img = "/img/I8.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },


                    new Car
                    {
                        Name = "Porsche Boxster",
                        ShortDesc = "Красивый и аккуратный",
                        LongDesc = "Точно привлечет внимание на улицах города",
                        Img = "/img/Порш.jpg",
                        Price = 50000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },


                    new Car
                    {
                        Name = "Land Rover Range Rover",
                        ShortDesc = "Дорогой и впечетляющий",
                        LongDesc = "Автомобиль сразу произвелет впечетление на окружение",
                        Img = "/img/Ровер.jpg",
                        Price = 30000,
                        IsFavourite = false,
                        Available = false,
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
                        new Category { CategoryName = "Электромобили", Desc = "Современный вид странспорта" },
                        new Category { CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();  //Добовляем элементы моссива в нее

                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);   //Добовляем новый обект          
                }

                return category;
            }
        }

    }
}
