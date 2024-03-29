using ClassLibrary;
using System.Text;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Money money = new Money(70, 20);
            Console.WriteLine(money.ToString());

            Dollar dollar = new Dollar(60, 00);
            Console.WriteLine(dollar.ToString());

            Euro price = new Euro(12, 12);
            Console.WriteLine(price.ToString());
            price.SetValues(20, 50);
            Console.WriteLine(price.ToString());
            
            Product product = new Product("Огірок", price);
            Console.WriteLine($"{product.Name} коштує {product.Price}\n");
            Euro decrease = new Euro(10, 20);
            product.DecreasePrice(decrease);
            Console.WriteLine($"{product.Name} коштує {product.Price}\n");

            Money priceForUnit = new Money(10, 50);

            Warehouse warehouse = new Warehouse();
            Reporting reporting = new Reporting(warehouse);
            WarehouseItem wItem = new WarehouseItem(product, "кг", priceForUnit, 10, new DateTime(2024, 12, 30));

            reporting.RegisterArrival(wItem);
            reporting.InventoryReport();
   
            Money priceForNewProduct = new Money(9, 70);
            Product productNew = new Product("Помідор", priceForNewProduct);
            WarehouseItem wNewItem = new WarehouseItem(productNew, "кг", priceForNewProduct, 50, new DateTime(2024, 12, 31));
            reporting.RegisterArrival(wNewItem);

            reporting.InventoryReport();

            reporting.RegisterDeparture(wItem);
            reporting.InventoryReport();
            
        }
    }
}
