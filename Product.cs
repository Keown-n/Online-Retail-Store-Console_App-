using System;

namespace ConsoleApp13
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(string name, double price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public abstract void DisplayProductDetails();
        

    }

    public class Electronic : Product
    {
        public string Brand { get; set; }
        public int WarrantyPeriod { get; set; } // In months

        public string type { get; set; }

        // Constructor for Electronic
        public Electronic(string name, double price, int stockQuantity, string brand, int warrantyPeriod)
            : base(name, price, stockQuantity)
        {
            Brand = brand;
            WarrantyPeriod = warrantyPeriod;
            this.type = "electronic";
        }

        public double getPrice() {

            return this.Price;        
        }

        // Overriding the DisplayProductDetails method
        public override void DisplayProductDetails()
        {
            Console.WriteLine($"Electronic: {Name}, Brand: {Brand}, Price: {Price:C}, Warranty: {WarrantyPeriod} months, Stock: {StockQuantity}");
        }

        public override string ToString()
        {
            return this.Price.ToString();
        }
    }

    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public string type { get; set; }
        // Constructor for Clothing
        public Clothing(string name, double price, int stockQuantity, string size, string material)
            : base(name, price, stockQuantity)
        {
            Size = size;
            Material = material;
            this.type = "clothing";
        }

        public double getPrice()
        {

            return this.Price;
        }

        // Overriding the DisplayProductDetails method
        public override void DisplayProductDetails()
        {
            Console.WriteLine($"Clothing: {Name}, Size: {Size}, Material: {Material}, Price: {Price:C}, Stock: {StockQuantity}");
        }
        
    }

    public class Grocery : Product
    {
        public DateTime ExpiryDate { get; set; }
        public string type { get; set; }

        // Constructor for Grocery
        public Grocery(string name, double price, int stockQuantity, DateTime expiryDate)
            : base(name, price, stockQuantity)
        {
            ExpiryDate = expiryDate;
            this.type = "grocery";
        }

        public double getPrice()
        {

            return this.Price;
        }

        // Overriding the DisplayProductDetails method
        public override void DisplayProductDetails()
        {
            Console.WriteLine($"Grocery: {Name}, Price: {Price:C}, Expiry Date: {ExpiryDate.ToShortDateString()}, Stock: {StockQuantity}");
        }
        
    }

}
