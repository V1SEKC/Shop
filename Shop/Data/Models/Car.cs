namespace Shop.Data.Models
{
    public class Car  //Опсание товаров
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; } //Описание длинное
        public string longDesc { get; set; }  //Описание короткое
        public string img { get; set; }  //Юрел адрес где будет картинка
        public ushort price { get; set; } //Со знаком - быть не может цена
        public bool isFavourite { get; set; }  //Отображение на главной стр true или false
        public bool available { get; set; }  //Если товар на складе и сколько
        public int categoryID { get; set; }  //Айди нужной категории. обект категории. Приклепляем товар к нужной категории 
        public virtual Category Category { get; set; }  //У одного товара есть лишь одна категория 
    }
}
