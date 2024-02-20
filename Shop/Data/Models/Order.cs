using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина имени должна быть не менее 5 символов")]
        public string Name { get; set; }

		[Display(Name = "Введите фамилию")]
		[StringLength(5)]
		[Required(ErrorMessage = "Длина фамалии должна быть не менее 5 символов")]
		public string surName { get; set; }

		[Display(Name = "Введите адресс")]
		[StringLength(5)]
		[Required(ErrorMessage = "Длина адреса должна быть не менее 5 символов")]
		public string adress { get; set; }

		[Display(Name = "Введите номер телефона")]
		[DataType(DataType.PhoneNumber)]
		[StringLength(10)] //НЕ больше
		[Required(ErrorMessage = "Длина телефона должна быть не менее 10 символов")]
		public string phone { get; set; }

		[Display(Name = "Введите емаил")]
		[DataType(DataType.EmailAddress)]
		[StringLength(15)]
		[Required(ErrorMessage = "Длина емайла должна быть не менее 15 символов")]
		public string email { get; set; }

		[BindNever]
		[ScaffoldColumn(false)] //Не отображалось
		public DateTime orderTime{ get; set; }
        public List<OrderDetail> orderDetail{ get; set; }
    }
}
