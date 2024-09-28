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
            //Loading the Stocks
            Electronic laptop = new Electronic("Laptop", 1200.00, 10, "Dell", 24);
            Clothing tshirt = new Clothing("T-Shirt", 20.00, 50, "L", "Cotton");
            Grocery apple = new Grocery("Apple", 2.00, 100, DateTime.Now.AddDays(5));

            double price = 0;
            Console.WriteLine("///////////////////////////////////////////////////////\n");
            Console.WriteLine("Laptop stock = "+laptop.StockQuantity);
            Console.WriteLine("T-shirt stock = " + tshirt.StockQuantity);
            Console.WriteLine("Apples stock = " + apple.StockQuantity);
            Console.WriteLine("///////////////////////////////////////////////////////\n");

            Console.WriteLine("///////////////////////////////////////////////////////");
            Console.WriteLine("/////////// WELCOME TO THE ONLINE RETAIL STORE/////////");
            Console.WriteLine("///////////////////////////////////////////////////////\n");



            Console.WriteLine("SELECT A PRODUCT BELOW:\n");
            Console.WriteLine("[0] - Laptop \t [1] - T-Shirt \t [2] - Apple \n [3] - Exit");
            Console.WriteLine("///////////////////////////////////////////////////////\n");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case ("0"):
                    Items item = new Items(laptop);
                    Order order = new Order(item);
                    order.ProcessOrder();
                    price = laptop.Price;
                    Console.WriteLine("///////////////////////////////////////////////////////\n");
                    Console.WriteLine(" Your Total is : R" + price);

                    break;

                case ("1"):

                    Items item2 = new Items(tshirt);
                    Order order2 = new Order(item2);
                    order2.ProcessOrder();
                    price = tshirt.Price;
                    Console.WriteLine(" Your Total is : R" + price);
                    break;

                case ("2"):

                    Items item3 = new Items(apple);
                    Order order3 = new Order(item3);
                    order3.ProcessOrder();
                    price = apple.Price;
                    Console.WriteLine(" Your Total is : R" + price);
                    break;

                case ("3"):
                    Console.WriteLine("Thank you for your time......................\n");

                    break;

                default:
                    break;
            }

            Console.WriteLine("///////////////////////////////////////////////////////\n");
            Console.WriteLine("Laptop stock = " + laptop.StockQuantity);
            Console.WriteLine("T-shirt stock = " + tshirt.StockQuantity);
            Console.WriteLine("Apples stock = " + apple.StockQuantity);
            Console.WriteLine("///////////////////////////////////////////////////////\n");






            //List<Items> items = new List<Items>();
            //Items item = new Items(laptop);
            //Items item2 = new Items(tshirt);
            //Items item3 = new Items(apple);

            //items.Add(item);
            //items.Add(item2);
            //items.Add(item3);

            //Order order = new Order(items);

            //order.ProcessMultipleOrder();
            ////Items item = new Items(apple);

            ////Order order = new Order(item);
            ////Console.WriteLine("///////////////////////////////////////////////////////\n");
            ////Console.WriteLine("///////////////////////APPLE BOUGHT////////////////////\n");
            ////Console.WriteLine("///////////////////////////////////////////////////////\n");

            ////order.ProcessOrder();
            //Console.WriteLine("///////////////////////////////////////////////////////\n");
            //Console.WriteLine("Laptop stock = " + laptop.StockQuantity);
            //Console.WriteLine("T-shirt stock = " + tshirt.StockQuantity);
            //Console.WriteLine("Apples stock = " + apple.StockQuantity);
            //Console.WriteLine("///////////////////////////////////////////////////////\n");

            ////Console.WriteLine("///////////////////////////////////////////////////////\n");
            ////order.ReturnProduct();
            //order.ReturnMultipleProduct();
            //Console.WriteLine("///////////////////////////////////////////////////////\n");
            //Console.WriteLine("Laptop stock = " + laptop.StockQuantity);
            //Console.WriteLine("T-shirt stock = " + tshirt.StockQuantity);
            //Console.WriteLine("Apples stock = " + apple.StockQuantity);
            //Console.WriteLine("///////////////////////////////////////////////////////\n");
            ////Console.WriteLine("Apples stock = " + apple.StockQuantity);


            ////Console.WriteLine(apple.StockQuantity);
            ////Console.WriteLine(laptop.StockQuantity);
            ////Console.WriteLine(tshirt.StockQuantity);

            Console.ReadKey();


        }
    }
}
