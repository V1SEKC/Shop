using System.Drawing.Printing;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        //Товар в нутри корзины
        public int Id {  get; set; }
        //public int id {  get; set; }
        public Car car { get; set; }
        public int price { get; set; }
        public string ShopCatId { get; set; }
    }
}
