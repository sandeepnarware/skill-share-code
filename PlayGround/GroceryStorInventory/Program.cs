using GroceryStorInventory.Model;
using System;

namespace GroceryStorInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Store myStore = InitializeStore();
            Console.WriteLine(" Hi, Welcome to my grocery store");
            bool shouldContinue = true;
            do
            {
                Console.WriteLine(" Please Choose One Option :");
                Console.WriteLine(" L for listing of items");
                Console.WriteLine(" A Adding a new item to store");
                Console.WriteLine(" D to delete an item form store");
                Console.WriteLine(" S to sell an item");
                Console.WriteLine(" E to Exist");
                Console.WriteLine(" C to relist option or continue");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "E":
                        shouldContinue = false;
                        break;
                    case "L":
                        myStore.List();
                        break;
                    case "A":
                        AddItemToStore(myStore);
                        break;
                    case "D":
                        DeleteItemFromStore(myStore);
                        break;
                    case "S":
                        SellItem(myStore);
                        break;
                    default:
                        break;
                }
            } while (shouldContinue);

        }

        private static void SellItem(Store myStore)
        {
            Console.WriteLine("Plasese Provide SKU to Sell :");
            var sku = Console.ReadLine();
            var inv = myStore.GetInventory(sku);
            Console.WriteLine(myStore.ShowInventory(inv));
            Console.WriteLine("Please Provide Qty For Sell : ");
            var sellQty = Convert.ToInt32(Console.ReadLine());
            myStore.Sell(inv, sellQty);
        }

        private static Store InitializeStore()
        {
            return new Store
            {
                Name = "ABC Grocery Store",
                Address = "Recidency Rode Bangalore",
                GST = "GST-05402456"
            };
        }

        private static void AddItemToStore(Store myStore)
        {
            Console.WriteLine(" Please provide Item SKU :");
            var sku = Console.ReadLine();
            Console.WriteLine(" Please provide Item Name :");
            var name = Console.ReadLine();
            Console.WriteLine(" Please provide Item Description :");
            var desc = Console.ReadLine();
            Console.WriteLine(" Please provide Item Unit Price :");
            var unitPrice = Console.ReadLine();
            Console.WriteLine(" Please provide Item Quantity :");
            var qty = Console.ReadLine();

            myStore.AddItem(new Inventory
            {
                InvQty = Convert.ToInt32(qty),
                Item = new Item
                {
                    Description = desc,
                    Name = name,
                    SKU = sku,
                    UnitPrice = unitPrice
                }
            });
        }

        private static void DeleteItemFromStore(Store mystore)
        {
            Console.WriteLine("Please Provide SKU To Delete Item :");
            var sku = Console.ReadLine();
            mystore.DeleletItem(sku);
        }
    }
}

