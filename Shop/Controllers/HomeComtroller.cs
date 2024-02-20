using System.Web.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
	public class HomeComtroller : Controller
	{
		private readonly IAllCars _carRep;
		public HomeComtroller(IAllCars carRep)
		{
			_carRep = carRep;
		}

		public ViewResult Index()
		{
			var homeCars = new HomeViewModels
			{
				favCars = _carRep.getFavCars
			};
			return View(homeCars);
		}
	}
}
