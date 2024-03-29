using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dollar : Money
    {

        public Dollar(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {

        }
        public override string ToString()
        {
            return $"{WholePart}.{FractionalPart} USD";
        }
    }
}
