using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface ICarService
    {
        void AddCar(Car car);
        void DisplayCarProp(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
    }
}
