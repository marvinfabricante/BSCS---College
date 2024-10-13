using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public abstract class Item
    {
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
            get { return item_price; }
            set { item_price = value; }
        }

        public int Item_Quantity
        {
            get { return item_quantity; }
            set { item_quantity = value; }
        }

    }
}

// I