using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            Console.WriteLine("*********************************************************************");
            Console.WriteLine(Environment.NewLine);

            foreach (var inv in Inventories)
            {
                Console.WriteLine($" SKU : {inv.Item.SKU}");
                Console.WriteLine($" Name : {inv.Item.Name}");
                Console.WriteLine($" Description : {inv.Item.Description}");
                Console.WriteLine($" QOH : {inv.InvQty}");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("*********************************************************************");
                Console.WriteLine(Environment.NewLine);
            }
        }

        public void AddItem(Inventory itemDetails)
        {
            CheckIfInventoyExistElseCreate();
            Inventories.Add(itemDetails);
        }

        private void CheckIfInventoyExistElseCreate()
        {
            Inventories = Inventories != null ? Inventories : new List<Inventory>();
        }

        public string DeleletItem(Inventory itemDetails)
        {
            CheckIfInventoyExistElseCreate();
            return DeleletItem(itemDetails.Item?.SKU);
        }

        public string DeleletItem(string sku)
        {
            CheckIfInventoyExistElseCreate();

            var inv = Inventories.FirstOrDefault(inv => inv.Item.SKU == sku);
            if (inv == null)
                return $"Error : There is not item with SKU {sku}";
            else
                Inventories.Remove(inv);

            return "Item Deleted Sucessfuliy";
        }

        public string Sell(Inventory inv, int sellQty)
        {
            if (sellQty > inv.InvQty)
                return "There is not sufficient Qty Avilable :(";
            else
                inv.InvQty -= sellQty;
            return "Item Sold Sucessfully";

        }

        public string ShowInventory(Inventory inv)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Item SKU : {inv.Item.SKU}");
            output.AppendLine($"Item Name : {inv.Item.Name}");
            output.AppendLine($"Item Qty On Hand : {inv.InvQty}");
            return output.ToString();
        }

        public Inventory GetInventory(string sku)
        {
            CheckIfInventoyExistElseCreate();
            return Inventories.FirstOrDefault(inv => inv.Item.SKU == sku);
        }
    }
}
