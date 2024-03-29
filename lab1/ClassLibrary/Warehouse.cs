using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse
    {
        public List<WarehouseItem> items = new List<WarehouseItem>();

        public void AddItem(WarehouseItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(WarehouseItem item)
        {
            items.Remove(item);
        }
    }
}
