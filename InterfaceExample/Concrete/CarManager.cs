using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Abstract;

namespace InterfaceExample.Concrete
{
    public class CarManager : ICarService
    {
        public void TAdd(Car t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Car t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Car t)
        {
            throw new NotImplementedException();
        }
    }
}
