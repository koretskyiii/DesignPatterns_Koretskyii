using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class iProneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new iProneLaptop();
        public INetbook CreateNetbook() => new iProneNetbook();
        public IEBook CreateEBook() => new iProneEBook();
        public ISmartphone CreateSmartphone() => new iProneSmartphone();
    }
}
