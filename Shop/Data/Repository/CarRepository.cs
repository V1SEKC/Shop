using System.CodeDom;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        //Реализуються в классах для работы с БД

        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent) //Задаем значение переменной выше
        {
            this.appDBContent = appDBContent;
        }

        //Получают данные из файла APP  
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);
        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);
        public Car getObjestCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.Id == carId);
    }
}
