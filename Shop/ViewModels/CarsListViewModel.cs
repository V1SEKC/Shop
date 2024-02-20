using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public IEnumerable<Car> getAllCars { get; set; }
        public string carrCategory { get; set; }
    }
}
