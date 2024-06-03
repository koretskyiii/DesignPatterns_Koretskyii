using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Artifact : InventoryDecorator
    {
        public Artifact(Hero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with artifact";
        }
    }
}
