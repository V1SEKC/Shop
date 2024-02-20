namespace Shop.Data.Models
{
    public class Category  //Модели категорий 
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; } //Описание
        public List<Car> cars { get; set; } //у каждой категории есть много таваров

    }
}
