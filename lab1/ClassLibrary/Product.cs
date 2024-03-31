using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; private set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void DecreasePrice(Money value)
        {
            if (value.WholePart < 0 || value.FractionalPart < 0 || value.WholePart > Price.WholePart || value.FractionalPart > Price.FractionalPart)
            {
                new ArgumentException("Сума на яку зменшується ціна, повинна бути більшою за нуль та не перевищувати поточну ціну"); // Fail First
            }
            Price.SetValues(Price.WholePart - value.WholePart, Price.FractionalPart - value.FractionalPart); 
        }
    }
}
