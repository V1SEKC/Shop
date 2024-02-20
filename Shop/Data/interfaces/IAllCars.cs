using Shop.Data.Models;

namespace Shop.Data.interfaces
{
    public interface IAllCars 
    {
        IEnumerable<Car> Cars { get; }  //Возвращает все товары
        IEnumerable<Car> getFavCars { get; }  //Возвращает избранные товары
        Car getObjestCar(int carId); //Возвращает товар по айди
    }
}
