using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Abstract;

namespace InterfaceExample.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void TAdd(Customer t)
        {
            Console.WriteLine(t.Name + " eklendi");
        }

        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Customer t)
        {
            throw new NotImplementedException();
        }
    }
}
