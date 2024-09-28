using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Order    
    {
        Items item;        

        Inventory inventory = new Inventory();

        List<Items> items;

        public Order(Items item)
        {
            this.item = item;
        }

        public Order(List<Items> items)
        {
            this.items = items;
        }

        public void ProcessOrder()
        {
           inventory.updateInventory(item); 

        }

        public void ProcessMultipleOrder()
        {
            inventory.MultipleUpdates(items);

        }


        public void ReturnProduct() {

            inventory.RemoveItem(item);
            
        
        }

        public void ReturnMultipleProduct()
        {
            inventory.RemoveMultiple(items);
        }

       

    }
}

