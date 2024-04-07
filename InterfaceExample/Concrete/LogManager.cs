using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Abstract;

namespace InterfaceExample.Concrete
{
    public class LogManager : ILogService
    {
        public void TAdd(Log t)
        {
            Console.WriteLine(t.Username + " " + t.Process);
        }

        public void TDelete(Log t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Log t)
        {
            throw new NotImplementedException();
        }
    }
}
