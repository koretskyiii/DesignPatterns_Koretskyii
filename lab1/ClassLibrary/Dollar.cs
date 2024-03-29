using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dollar : Money, ICurrency
    {
        
        public Dollar(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {
            CurrencyCode = "USD";
        }
    }
}
