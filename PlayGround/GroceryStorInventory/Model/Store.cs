using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStorInventory.Model
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string GST { get; set; }
        public List<Inventory> Inventories = new List<Inventory>();

        public void List()
        {
            if (Inventories == null || Inventories.Count <= 0)
            {
                Console.WriteLine("Not items aviable in store ;(");
                return;
            }

            foreach (var inv in Inventories)
            {
                Console.WriteLine($"SKU : {inv.Item.SKU}");
                Console.WriteLine($"Name : {inv.Item.Name}");
                Console.WriteLine($"Description : {inv.Item.Description}");
                Console.WriteLine($"QOH : {inv.InvQty}");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("*********************************************************************");
                Console.WriteLine(Environment.NewLine);
            }
        }

        public void AddItem(Inventory itemDetails)
        {
            if (Inventories == null)
                Inventories = new List<Inventory>();

            Inventories.Add(itemDetails);
        }

        public void DeleletItem(Inventory itemDetails)
        {
            if (Inventories == null)
                Inventories = new List<Inventory>();

            var inv = Inventories.FirstOrDefault(inv => inv.Item.SKU == itemDetails.Item.SKU);
            if (inv == null)
                Console.WriteLine($"Error : There is not item with SKU {itemDetails.Item.SKU}");
            else
                Inventories.Remove(inv);
        }
    }
}
