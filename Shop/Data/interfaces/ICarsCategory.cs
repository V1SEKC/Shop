using Shop.Data.Models;

namespace Shop.Data.interfaces
{
        public interface ICarsCategory //Вынимает инфу из моделей
        { 
            IEnumerable<Category> AllCategories { get; }  //Возвращает все категории из модели категории
        } 
}
