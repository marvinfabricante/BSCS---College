using System;

namespace CashierApplication
{
    public class DiscountedItem : Item
    {
        #region -- DiscountedItem Class: Extends Item Abstract Class --
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        public override double getTotalPrice()
        {
            this.discounted_price = item_price - (item_price * (this.item_discount * 0.01));
            Total_Price = item_quantity * (this.discounted_price);
            return Total_Price;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
            this.change = this.payment_amount - Total_Price;
        }

        public double getChange()
        {
            return this.change;
        }

        public double Item_Discount
        {
            get { return this.item_discount; }
            set { this.item_discount = value; }
        }

        public double Discounted_Price
        {
            get { return this.discounted_price; }
            set { this.discounted_price = value; }
        }

        public double Payment_Amount
        {
            get { return this.payment_amount; }
            set { this.payment_amount = value; }
        }

        public double Change
        {
            get { return this.change; }
            set { this.change = value; }
        }
        #endregion
    }
}
