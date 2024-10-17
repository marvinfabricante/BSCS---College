using System;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private frmLoginAccount login;
        private DiscountedItem discountedItem;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
            this.CenterToScreen();
            #region -- Menu Initialization: Set up the menu items and their actions --
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("File");
            menuStrip.Items.Add(fileMenuItem);
            ToolStripMenuItem logOutMenuItem = new ToolStripMenuItem("Logout");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit Application");
            fileMenuItem.DropDownItems.Add(logOutMenuItem);
            fileMenuItem.DropDownItems.Add(exitMenuItem);

            logOutMenuItem.Click += (sender, e) =>
            {
                this.Hide();
                login = new frmLoginAccount();
                login.Show();
            };

            exitMenuItem.Click += (sender, e) =>
            {
                Application.Exit();
            };
            #endregion
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            #region -- Compute Total Price: Read input values and calculate total amount --
            string itemName = TxtboxItemName.Text;
            double itemPrice = Convert.ToDouble(TxtboxPrice.Text);
            int itemQuantity = Convert.ToInt32(TxtboxQuantity.Text);
            double itemDiscount = Convert.ToDouble(TxtboxDiscount.Text);

            discountedItem = new DiscountedItem(itemName, itemPrice, itemQuantity, itemDiscount);
            double totalAmount = discountedItem.getTotalPrice();
            LblTotalAmountResult.Text = totalAmount.ToString();
            #endregion
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            #region -- Process Payment: Validate and calculate change from payment --
            if (discountedItem == null)
            {
                MessageBox.Show("Please compute the total amount first.");
                return;
            }

            double paymentAmount = Convert.ToDouble(TxtboxPaymentReceived.Text);
            discountedItem.setPayment(paymentAmount);

            double change = discountedItem.getChange();
            LblChangeResult.Text = change.ToString();
            #endregion
        }
    }
}
