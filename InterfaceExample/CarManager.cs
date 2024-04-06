using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class CarManager : ICarService
    {
        public void AddCar(Car car)
        {
            Console.WriteLine(car.Brand + "eklendi");
        }

        public void DeleteCar(Car car)
        {
            Console.WriteLine(car.Brand + "silindi");
        }

        public void DisplayCarProp(Car car)
        {
            Console.WriteLine(car.Brand + "\n"+car.Model + "\n"+car.Year+"\n"+car.Price);
        }

        public void UpdateCar(Car car)
        {
            Console.WriteLine(car.Brand + "güncellendi");
        }
    }
}
