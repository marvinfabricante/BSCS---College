using System;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        private frmPurchaseDiscountedItem purchaseItemForm;

        public frmLoginAccount()
        {
            InitializeComponent();
            this.CenterToScreen();
            cashier = new Cashier("Marvin Fabricante", "Marbs", "MarvinPogi", "STI Ortigas-Cainta");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (cashier.validateLogin(TxtboxUsername.Text, TxtboxPassword.Text))
            {
                MessageBox.Show($"Welcome {cashier.getFullName()} of {cashier.getDepartment()}");
                Hide();
                purchaseItemForm = new frmPurchaseDiscountedItem();
                purchaseItemForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!");
            }
        }
    }
}
