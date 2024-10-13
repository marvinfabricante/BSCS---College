namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripFileOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LblItemName = new System.Windows.Forms.Label();
            this.TxtboxItemName = new System.Windows.Forms.TextBox();
            this.TxtboxDiscount = new System.Windows.Forms.TextBox();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtboxPrice = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TxtboxQuantity = new System.Windows.Forms.TextBox();
            this.BtnCompute = new System.Windows.Forms.Button();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.LblTotalAmountResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtboxPaymentReceived = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LblChange = new System.Windows.Forms.Label();
            this.LblChangeResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFileOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripFileOptions
            // 
            this.MenuStripFileOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.MenuStripFileOptions.Name = "MenuStripFileOptions";
            this.MenuStripFileOptions.Size = new System.Drawing.Size(37, 20);
            this.MenuStripFileOptions.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LblItemName
            // 
            this.LblItemName.AutoSize = true;
            this.LblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemName.Location = new System.Drawing.Point(12, 47);
            this.LblItemName.Name = "LblItemName";
            this.LblItemName.Size = new System.Drawing.Size(106, 24);
            this.LblItemName.TabIndex = 2;
            this.LblItemName.Text = "Item Name:";
            // 
            // TxtboxItemName
            // 
            this.TxtboxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxItemName.Location = new System.Drawing.Point(17, 75);
            this.TxtboxItemName.Name = "TxtboxItemName";
            this.TxtboxItemName.Size = new System.Drawing.Size(246, 29);
            this.TxtboxItemName.TabIndex = 3;
            // 
            // TxtboxDiscount
            // 
            this.TxtboxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxDiscount.Location = new System.Drawing.Point(289, 75);
            this.TxtboxDiscount.Name = "TxtboxDiscount";
            this.TxtboxDiscount.Size = new System.Drawing.Size(183, 29);
            this.TxtboxDiscount.TabIndex = 5;
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiscount.Location = new System.Drawing.Point(284, 47);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(120, 24);
            this.LblDiscount.TabIndex = 4;
            this.LblDiscount.Text = "Discount (%):";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(12, 109);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(58, 24);
            this.LblPrice.TabIndex = 6;
            this.LblPrice.Text = "Price:";
            // 
            // TxtboxPrice
            // 
            this.TxtboxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxPrice.Location = new System.Drawing.Point(85, 109);
            this.TxtboxPrice.Name = "TxtboxPrice";
            this.TxtboxPrice.Size = new System.Drawing.Size(178, 29);
            this.TxtboxPrice.TabIndex = 7;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(284, 115);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(83, 24);
            this.LblQuantity.TabIndex = 8;
            this.LblQuantity.Text = "Quantity:";
            // 
            // TxtboxQuantity
            // 
            this.TxtboxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxQuantity.Location = new System.Drawing.Point(373, 115);
            this.TxtboxQuantity.Name = "TxtboxQuantity";
            this.TxtboxQuantity.Size = new System.Drawing.Size(99, 29);
            this.TxtboxQuantity.TabIndex = 9;
            // 
            // BtnCompute
            // 
            this.BtnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompute.Location = new System.Drawing.Point(165, 146);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(132, 31);
            this.BtnCompute.TabIndex = 10;
            this.BtnCompute.Text = "Compute";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.Location = new System.Drawing.Point(65, 211);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(127, 24);
            this.LblTotalAmount.TabIndex = 11;
            this.LblTotalAmount.Text = "Total Amount:";
            // 
            // LblTotalAmountResult
            // 
            this.LblTotalAmountResult.AutoSize = true;
            this.LblTotalAmountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmountResult.Location = new System.Drawing.Point(216, 211);
            this.LblTotalAmountResult.Name = "LblTotalAmountResult";
            this.LblTotalAmountResult.Size = new System.Drawing.Size(45, 24);
            this.LblTotalAmountResult.TabIndex = 12;
            this.LblTotalAmountResult.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Payment Received:";
            // 
            // TxtboxPaymentReceived
            // 
            this.TxtboxPaymentReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxPaymentReceived.Location = new System.Drawing.Point(189, 285);
            this.TxtboxPaymentReceived.Name = "TxtboxPaymentReceived";
            this.TxtboxPaymentReceived.Size = new System.Drawing.Size(135, 29);
            this.TxtboxPaymentReceived.TabIndex = 14;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(330, 285);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(132, 31);
            this.BtnSubmit.TabIndex = 15;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LblChange
            // 
            this.LblChange.AutoSize = true;
            this.LblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.Location = new System.Drawing.Point(97, 339);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(82, 24);
            this.LblChange.TabIndex = 16;
            this.LblChange.Text = "Change:";
            // 
            // LblChangeResult
            // 
            this.LblChangeResult.AutoSize = true;
            this.LblChangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangeResult.Location = new System.Drawing.Point(185, 339);
            this.LblChangeResult.Name = "LblChangeResult";
            this.LblChangeResult.Size = new System.Drawing.Size(45, 24);
            this.LblChangeResult.TabIndex = 17;
            this.LblChangeResult.Text = "0.00";
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 372);
            this.Controls.Add(this.LblChangeResult);
            this.Controls.Add(this.LblChange);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtboxPaymentReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTotalAmountResult);
            this.Controls.Add(this.LblTotalAmount);
            this.Controls.Add(this.BtnCompute);
            this.Controls.Add(this.TxtboxQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TxtboxPrice);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtboxDiscount);
            this.Controls.Add(this.LblDiscount);
            this.Controls.Add(this.TxtboxItemName);
            this.Controls.Add(this.LblItemName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Purchase Discounted Item";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileOptions;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LblItemName;
        private System.Windows.Forms.TextBox TxtboxItemName;
        private System.Windows.Forms.TextBox TxtboxDiscount;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtboxPrice;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TxtboxQuantity;
        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.Label LblTotalAmountResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtboxPaymentReceived;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblChange;
        private System.Windows.Forms.Label LblChangeResult;
    }
}