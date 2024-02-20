using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    /// <summary>
    /// Описание товаров
    /// </summary>
    public class Car  //Опсание товаров
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; } //Описание длинное
        public string LongDesc { get; set; }  //Описание короткое
        public string Img { get; set; }  //Юрел адрес где будет картинка
        public ushort Price { get; set; } //Со знаком - быть не может цена
        public bool IsFavourite { get; set; }  //Отображение на главной стр true или false
        public bool Available { get; set; }  //Если товар на складе и сколько
        public int CategoryID { get; set; }  //Айди нужной категории. обект категории. Приклепляем товар к нужной категории 
        public virtual Category Category { get; set; }  //У одного товара есть лишь одна категория 
    }
}
