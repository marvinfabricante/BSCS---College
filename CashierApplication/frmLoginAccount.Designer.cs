namespace CashierApplication
{
    partial class frmLoginAccount
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
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtboxUsername = new System.Windows.Forms.TextBox();
            this.TxtboxPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUsername
            // 
            this.LblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(13, 13);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(106, 30);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username";
            // 
            // TxtboxUsername
            // 
            this.TxtboxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtboxUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxUsername.Location = new System.Drawing.Point(19, 46);
            this.TxtboxUsername.Name = "TxtboxUsername";
            this.TxtboxUsername.Size = new System.Drawing.Size(217, 35);
            this.TxtboxUsername.TabIndex = 1;
            // 
            // TxtboxPassword
            // 
            this.TxtboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtboxPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxPassword.Location = new System.Drawing.Point(20, 117);
            this.TxtboxPassword.Name = "TxtboxPassword";
            this.TxtboxPassword.PasswordChar = '●';
            this.TxtboxPassword.Size = new System.Drawing.Size(216, 35);
            this.TxtboxPassword.TabIndex = 3;
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(14, 84);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(99, 30);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogin.Location = new System.Drawing.Point(20, 167);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(216, 35);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // frmLoginAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 221);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtboxPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtboxUsername);
            this.Controls.Add(this.LblUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginAccount";
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtboxUsername;
        private System.Windows.Forms.TextBox TxtboxPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}

