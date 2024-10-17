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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.LblItem = new System.Windows.Forms.Label();
            this.TxtboxItemName = new System.Windows.Forms.TextBox();
            this.TxtboxDiscount = new System.Windows.Forms.TextBox();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.TxtboxPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtboxQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.BtnCompute = new System.Windows.Forms.Button();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.LblTotalAmountResult = new System.Windows.Forms.Label();
            this.LblPaymentReceived = new System.Windows.Forms.Label();
            this.TxtboxPaymentReceived = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LblChange = new System.Windows.Forms.Label();
            this.LblChangeResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(521, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // LblItem
            // 
            this.LblItem.AutoSize = true;
            this.LblItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.Location = new System.Drawing.Point(12, 34);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(60, 30);
            this.LblItem.TabIndex = 1;
            this.LblItem.Text = "Item:";
            // 
            // TxtboxItemName
            // 
            this.TxtboxItemName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxItemName.Location = new System.Drawing.Point(17, 67);
            this.TxtboxItemName.Name = "TxtboxItemName";
            this.TxtboxItemName.Size = new System.Drawing.Size(285, 35);
            this.TxtboxItemName.TabIndex = 2;
            // 
            // TxtboxDiscount
            // 
            this.TxtboxDiscount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxDiscount.Location = new System.Drawing.Point(323, 67);
            this.TxtboxDiscount.Name = "TxtboxDiscount";
            this.TxtboxDiscount.Size = new System.Drawing.Size(181, 35);
            this.TxtboxDiscount.TabIndex = 4;
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiscount.Location = new System.Drawing.Point(318, 34);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(135, 30);
            this.LblDiscount.TabIndex = 3;
            this.LblDiscount.Text = "Discount (%):";
            // 
            // TxtboxPrice
            // 
            this.TxtboxPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxPrice.Location = new System.Drawing.Point(81, 108);
            this.TxtboxPrice.Name = "TxtboxPrice";
            this.TxtboxPrice.Size = new System.Drawing.Size(221, 35);
            this.TxtboxPrice.TabIndex = 6;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(12, 105);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(63, 30);
            this.LblPrice.TabIndex = 5;
            this.LblPrice.Text = "Price:";
            // 
            // TxtboxQuantity
            // 
            this.TxtboxQuantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxQuantity.Location = new System.Drawing.Point(422, 108);
            this.TxtboxQuantity.Name = "TxtboxQuantity";
            this.TxtboxQuantity.Size = new System.Drawing.Size(82, 35);
            this.TxtboxQuantity.TabIndex = 8;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(318, 108);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(98, 30);
            this.LblQuantity.TabIndex = 7;
            this.LblQuantity.Text = "Quantity:";
            // 
            // BtnCompute
            // 
            this.BtnCompute.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompute.Location = new System.Drawing.Point(210, 149);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(128, 35);
            this.BtnCompute.TabIndex = 9;
            this.BtnCompute.Text = "Compute";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.Location = new System.Drawing.Point(65, 214);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(143, 30);
            this.LblTotalAmount.TabIndex = 10;
            this.LblTotalAmount.Text = "Total Amount:";
            // 
            // LblTotalAmountResult
            // 
            this.LblTotalAmountResult.AutoSize = true;
            this.LblTotalAmountResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmountResult.Location = new System.Drawing.Point(233, 214);
            this.LblTotalAmountResult.Name = "LblTotalAmountResult";
            this.LblTotalAmountResult.Size = new System.Drawing.Size(0, 30);
            this.LblTotalAmountResult.TabIndex = 11;
            // 
            // LblPaymentReceived
            // 
            this.LblPaymentReceived.AutoSize = true;
            this.LblPaymentReceived.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaymentReceived.Location = new System.Drawing.Point(25, 277);
            this.LblPaymentReceived.Name = "LblPaymentReceived";
            this.LblPaymentReceived.Size = new System.Drawing.Size(186, 30);
            this.LblPaymentReceived.TabIndex = 12;
            this.LblPaymentReceived.Text = "Payment Received:";
            // 
            // TxtboxPaymentReceived
            // 
            this.TxtboxPaymentReceived.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxPaymentReceived.Location = new System.Drawing.Point(213, 277);
            this.TxtboxPaymentReceived.Name = "TxtboxPaymentReceived";
            this.TxtboxPaymentReceived.Size = new System.Drawing.Size(159, 35);
            this.TxtboxPaymentReceived.TabIndex = 13;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(378, 279);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(98, 34);
            this.BtnSubmit.TabIndex = 14;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LblChange
            // 
            this.LblChange.AutoSize = true;
            this.LblChange.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.Location = new System.Drawing.Point(119, 337);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(89, 30);
            this.LblChange.TabIndex = 15;
            this.LblChange.Text = "Change:";
            // 
            // LblChangeResult
            // 
            this.LblChangeResult.AutoSize = true;
            this.LblChangeResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangeResult.Location = new System.Drawing.Point(233, 337);
            this.LblChangeResult.Name = "LblChangeResult";
            this.LblChangeResult.Size = new System.Drawing.Size(0, 30);
            this.LblChangeResult.TabIndex = 16;
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 386);
            this.Controls.Add(this.LblChangeResult);
            this.Controls.Add(this.LblChange);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtboxPaymentReceived);
            this.Controls.Add(this.LblPaymentReceived);
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
            this.Controls.Add(this.LblItem);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Purchase Discounted Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label LblItem;
        private System.Windows.Forms.TextBox TxtboxItemName;
        private System.Windows.Forms.TextBox TxtboxDiscount;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.TextBox TxtboxPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtboxQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.Label LblTotalAmountResult;
        private System.Windows.Forms.Label LblPaymentReceived;
        private System.Windows.Forms.TextBox TxtboxPaymentReceived;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblChange;
        private System.Windows.Forms.Label LblChangeResult;
    }
}