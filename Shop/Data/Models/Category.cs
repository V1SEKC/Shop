namespace Shop.Data.Models
{
    public class Category  //Модели категорий 
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; } //Описание
        public List<Car> Cars { get; set; } //у каждой категории есть много таваров

    }
}
