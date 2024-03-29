using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void RegisterArrival(WarehouseItem item)
        {
            warehouse.AddItem(item);
        }

        public void RegisterDeparture(WarehouseItem item)
        {
            warehouse.RemoveItem(item);
        }

        public void InventoryReport()
        {
            Console.WriteLine($"Звіт з інвентаризації - залишки на складі: \n");

            foreach (var item in warehouse.items)
            {
                Console.WriteLine($"{item.Product.Name}: {item.Quantity}");
            }
        }
    }
}
