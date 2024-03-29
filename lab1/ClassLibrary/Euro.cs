using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Euro : Money
    {
        public Euro(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {
    
        }
        public override string ToString()
        {
            return $"{WholePart}.{FractionalPart} EUR";
        }
    }
}
