using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        internal IEnumerable<Car> allCars;

        public IEnumerable<Car> getAllCars { get; set; }
        public string carrCategory { get; set; }
    }
}
