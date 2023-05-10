using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata.Models
{
    public class ItemModel
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public ItemModel(double price, string name, int quantity)
        {
            Price = price;
            Name = name;
            Quantity = quantity;
        }
    }
}
