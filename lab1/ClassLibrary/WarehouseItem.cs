using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WarehouseItem
    {
        public Product Product {  get; set; }
        public string UnitOfMeasure { get; set; }
        public Money PricePerUnit { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }

        public WarehouseItem(Product product, string unitOfMeasure, Money pricePerUnit, int quantity, DateTime lastDeliveryUpdate) {

            Product = product;
            UnitOfMeasure = unitOfMeasure;
            PricePerUnit = pricePerUnit;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryUpdate;
        }

    }
}
