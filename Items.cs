using System;

namespace ConsoleApp13
{
    class Items
    {
        Electronic electronic;
        Clothing clothing;
        Grocery grocery;
        
        string type;


        public Items(Electronic electronic, Clothing clothing, Grocery grocery)
        {
            this.electronic = electronic;
            this.clothing = clothing;
            this.grocery = grocery;

            

        }

        public Items()
        {
            ////
        }

        public Items(Electronic electronic)
        {
            this.electronic = electronic;
            this.type = electronic.type;
        }

        public Items(Clothing clothing)
        {
            this.clothing = clothing;
            this.type = clothing.type;

        }

        public Items(Grocery grocery)
        {
            this.grocery = grocery;
            this.type = grocery.type;
        }

        public double getElectronicPrice()
        {
            return electronic.Price; 
        }

        public double getClothingPrice()
        {
            return clothing.Price;
        }

        public double getGroceryPrice()
        {
            return grocery.Price;
        }

        public int getElectronicStock()
        {
            return electronic.StockQuantity;
        }

        public int getClothingStock()
        {
            return clothing.StockQuantity;
        }

        public int getGroceryStock()
        {
            return grocery.StockQuantity;
        }

        public void setElectronicStock(int num) {

            electronic.StockQuantity = num;

        }
        public void setClothingStock(int num)
        {
            clothing.StockQuantity = num;

        }
        public void setGroceryStock(int num)
        {
            grocery.StockQuantity = num;

        }

        public int getWarranty()
        {
            return electronic.WarrantyPeriod;
        }

        public DateTime getExpiry()
        {
            return grocery.ExpiryDate;
        }

        public string getType() {

            return this.type;
        
        }

    }
}

