using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory  //Риальзовываем интерфейс
    {
        public IEnumerable<Category> AllCategories  //Реализовываем сатегории
        {
            get 
            {
                return new List<Category>
                {
                     new Category { CategoryName = "Электромобили", Desc = "Современный вид странспорта" },
                     new Category { CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                };
            
            }
        }
    }
}
