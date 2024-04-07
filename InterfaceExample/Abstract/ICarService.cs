using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Concrete;

namespace InterfaceExample.Abstract
{
    public interface ICarService : IGenericService<Car>
    {

    }
}
