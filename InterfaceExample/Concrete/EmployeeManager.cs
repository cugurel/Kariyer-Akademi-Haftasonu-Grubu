using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Abstract;

namespace InterfaceExample.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        public void TAdd(Employee t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Employee t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Employee t)
        {
            throw new NotImplementedException();
        }
    }
}
