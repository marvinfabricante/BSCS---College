using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private frmLoginAccount login;
        private DiscountedItem item;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new frmLoginAccount();
            login.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            item = new DiscountedItem(TxtboxItemName.Text, double.Parse(TxtboxPrice.Text), int.Parse(TxtboxQuantity.Text), double.Parse(TxtboxDiscount.Text));
            LblTotalAmountResult.Text = item.getTotalPrice().ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            item.setPayment(double.Parse(TxtboxPaymentReceived.Text));
            LblChangeResult.Text = item.getChange().ToString();
        }
    }
}

// L