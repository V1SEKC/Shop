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
                     new Category { categoryName = "Электромобили", desc = "Современный вид странспорта" },
                     new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                };
            
            }
        }
    }
}
