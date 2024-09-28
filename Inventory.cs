using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Inventory
    {
        public Inventory()
        {
        }

        public void updateInventory(Items item)
        {
            string type = item.getType();
            int latest = 0;

            switch (type)
            {
                case "electronic":
                    latest = item.getElectronicStock()-1;

                    if(latest<= 0)
                    {
                        Console.WriteLine("Out of Stock");
                        break;
                    }
                    else { 
                        item.setElectronicStock(latest);
                        Console.WriteLine("Processed Electronic product...");
                        break;
                    }
                    

                case "clothing":
                    latest = item.getClothingStock() - 1;

                    if (latest <= 0)
                    {
                        Console.WriteLine("Out of Stock");
                        break;
                    }
                    else
                    {
                        item.setClothingStock(latest);
                        Console.WriteLine("Processed Clothing product...");
                        break;
                    }

                case "grocery":
                    latest = item.getGroceryStock() - 1;

                    if (latest <= 0)
                    {
                        Console.WriteLine("Out of Stock");
                        break;
                    }
                    else
                    {
                        item.setGroceryStock(latest);
                        Console.WriteLine("Processed Grocery product...");
                        break;
                    }

                default:
                   
                    Console.WriteLine("An Error has occurd please try again");
                    break;
            }
        }

        public void RemoveItem(Items item) {

            string type = item.getType();
            int latest = 0;

            switch (type)
            {
                case "electronic":
                    latest = item.getElectronicStock() + 1;
                 
                        item.setElectronicStock(latest);
                        Console.WriteLine("Processed Electronic product...");
                        break;

                case "clothing":
                    latest = item.getClothingStock() + 1;
                                       
                        item.setClothingStock(latest);
                        Console.WriteLine("Processed Clothing product...");
                        break;
                    

                case "grocery":
                    latest = item.getGroceryStock() + 1;
                    DateTime today = DateTime.Now.AddDays(57);

                    if(today< item.getExpiry())
                    {
                        item.setGroceryStock(latest);
                        Console.WriteLine("Processed Grocery product...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cannot Process Refund due to product being expired");
                        break;

                    }             

                default:

                    Console.WriteLine("An Error has occurd please try again");
                    break;
            }

        }

        public void MultipleUpdates(List<Items> items)
        {
            foreach (var item in items)
            {
                updateInventory(item);
            }
        }

        public void RemoveMultiple (List<Items> items)
        {
            foreach (var item in items)
            {
                RemoveItem(item);
            }

        }
    }
}

