using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{

    class Program
    {
        static void Main(string[] args)
        {
            Electronic laptop = new Electronic("Laptop", 1200.00, 10, "Dell", 24);
            Clothing tshirt = new Clothing("T-Shirt", 20.00, 50, "L", "Cotton");
            Grocery apple = new Grocery("Apple", 2.00, 100, DateTime.Now.AddDays(5));

           // Console.WriteLine(apple.StockQuantity);

            Items item = new Items(apple);
            Items item2 = new Items(laptop);
            Items item3 = new Items(tshirt);

            List<Items> items = new List<Items>();

            items.Add(item);
            items.Add(item2);
            items.Add(item3);

            Order order = new Order(items);

            order.ProcessMultipleOrder();


            //Order order = new Order(item);           

            //order.ProcessOrder();
            Console.WriteLine(apple.StockQuantity);
            Console.WriteLine(laptop.StockQuantity);
            Console.WriteLine(tshirt.StockQuantity);
            Console.WriteLine("////////////////////////////////////////////////////");

            //order.ReturnProduct();
            //Console.WriteLine(apple.StockQuantity);

            order.ReturnMultipleProduct();
            Console.WriteLine(apple.StockQuantity);
            Console.WriteLine(laptop.StockQuantity);
            Console.WriteLine(tshirt.StockQuantity);

            Console.ReadKey();


        }
    }
}
