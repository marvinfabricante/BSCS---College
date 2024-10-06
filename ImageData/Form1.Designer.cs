namespace ImageData
{
    partial class Form1
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
            this.lblLastname = new System.Windows.Forms.Label();
            this.lastnameTxtbox = new System.Windows.Forms.TextBox();
            this.firstnameTxtbox = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.middlenameTxtbox = new System.Windows.Forms.TextBox();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.emailAddressTxtbox = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.phoneNumberTxtbox = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.userControl11 = new ImageData.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(14, 54);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(92, 21);
            this.lblLastname.TabIndex = 0;
            this.lblLastname.Text = "Last name *";
            // 
            // lastnameTxtbox
            // 
            this.lastnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtbox.Location = new System.Drawing.Point(16, 78);
            this.lastnameTxtbox.Name = "lastnameTxtbox";
            this.lastnameTxtbox.Size = new System.Drawing.Size(248, 24);
            this.lastnameTxtbox.TabIndex = 1;
            // 
            // firstnameTxtbox
            // 
            this.firstnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtbox.Location = new System.Drawing.Point(16, 132);
            this.firstnameTxtbox.Name = "firstnameTxtbox";
            this.firstnameTxtbox.Size = new System.Drawing.Size(248, 24);
            this.firstnameTxtbox.TabIndex = 3;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(12, 108);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(94, 21);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "First name *";
            // 
            // middlenameTxtbox
            // 
            this.middlenameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenameTxtbox.Location = new System.Drawing.Point(14, 188);
            this.middlenameTxtbox.Name = "middlenameTxtbox";
            this.middlenameTxtbox.Size = new System.Drawing.Size(250, 24);
            this.middlenameTxtbox.TabIndex = 5;
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.Location = new System.Drawing.Point(10, 165);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(107, 20);
            this.lblMiddlename.TabIndex = 4;
            this.lblMiddlename.Text = "Middle name *";
            // 
            // emailAddressTxtbox
            // 
            this.emailAddressTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTxtbox.Location = new System.Drawing.Point(14, 250);
            this.emailAddressTxtbox.Name = "emailAddressTxtbox";
            this.emailAddressTxtbox.Size = new System.Drawing.Size(250, 24);
            this.emailAddressTxtbox.TabIndex = 7;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(10, 226);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(117, 21);
            this.lblEmailAddress.TabIndex = 6;
            this.lblEmailAddress.Text = "Email address *";
            // 
            // phoneNumberTxtbox
            // 
            this.phoneNumberTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTxtbox.Location = new System.Drawing.Point(14, 303);
            this.phoneNumberTxtbox.Name = "phoneNumberTxtbox";
            this.phoneNumberTxtbox.Size = new System.Drawing.Size(250, 24);
            this.phoneNumberTxtbox.TabIndex = 9;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(10, 279);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(124, 21);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone number *";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Crimson;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(57, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 36);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 32);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Student Registration *";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(300, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 273);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Crimson;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse.Location = new System.Drawing.Point(386, 333);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(157, 36);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(1, -1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(653, 430);
            this.userControl11.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 391);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.phoneNumberTxtbox);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.emailAddressTxtbox);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.middlenameTxtbox);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.firstnameTxtbox);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lastnameTxtbox);
            this.Controls.Add(this.lblLastname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox lastnameTxtbox;
        private System.Windows.Forms.TextBox firstnameTxtbox;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox middlenameTxtbox;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.TextBox emailAddressTxtbox;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox phoneNumberTxtbox;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private UserControl1 userControl11;
    }
}

