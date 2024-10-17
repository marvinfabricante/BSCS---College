using System;

namespace CashierApplication
{
    public abstract class Item
    {
        #region -- Item Abstract Base Class: Represents a generic item with a name, price, and quantity --
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);

        public double Total_Price
        {
            get { return this.total_price; }
            set { this.total_price = value; }
        }

        public string Item_Name
        {
            get { return this.item_name; }
            set { this.item_name = value; }
        }

        public double Item_Price
        {
            get { return this.item_price; }
            set { this.item_price = value; }
        }

        public int Item_Quantity
        {
            get { return this.item_quantity; }
            set { this.item_quantity = value; }
        }
        #endregion
    }
}
