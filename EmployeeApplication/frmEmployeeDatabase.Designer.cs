namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddEmployee = new Label();
            lblEmployeeID = new Label();
            employeeIDTxtbox = new TextBox();
            firstnameTxtbox = new TextBox();
            lblFirstname = new Label();
            lastnameTxtbox = new TextBox();
            lblLastname = new Label();
            positionTxtbox = new TextBox();
            lblPosition = new Label();
            submitBtn = new Button();
            lblEmployeeList = new Label();
            table = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // lblAddEmployee
            // 
            lblAddEmployee.Anchor = AnchorStyles.None;
            lblAddEmployee.AutoSize = true;
            lblAddEmployee.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEmployee.Location = new Point(12, 9);
            lblAddEmployee.Name = "lblAddEmployee";
            lblAddEmployee.Size = new Size(141, 25);
            lblAddEmployee.TabIndex = 0;
            lblAddEmployee.Text = "Add Employee:";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.Anchor = AnchorStyles.None;
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeID.Location = new Point(12, 56);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(100, 21);
            lblEmployeeID.TabIndex = 1;
            lblEmployeeID.Text = "Employee ID:";
            // 
            // employeeIDTxtbox
            // 
            employeeIDTxtbox.Anchor = AnchorStyles.None;
            employeeIDTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeIDTxtbox.Location = new Point(12, 80);
            employeeIDTxtbox.Name = "employeeIDTxtbox";
            employeeIDTxtbox.Size = new Size(247, 27);
            employeeIDTxtbox.TabIndex = 2;
            // 
            // firstnameTxtbox
            // 
            firstnameTxtbox.Anchor = AnchorStyles.None;
            firstnameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnameTxtbox.Location = new Point(12, 134);
            firstnameTxtbox.Name = "firstnameTxtbox";
            firstnameTxtbox.Size = new Size(247, 27);
            firstnameTxtbox.TabIndex = 4;
            // 
            // lblFirstname
            // 
            lblFirstname.Anchor = AnchorStyles.None;
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.Location = new Point(12, 110);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(94, 21);
            lblFirstname.TabIndex = 3;
            lblFirstname.Text = "First name *";
            // 
            // lastnameTxtbox
            // 
            lastnameTxtbox.Anchor = AnchorStyles.None;
            lastnameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnameTxtbox.Location = new Point(12, 188);
            lastnameTxtbox.Name = "lastnameTxtbox";
            lastnameTxtbox.Size = new Size(247, 27);
            lastnameTxtbox.TabIndex = 6;
            // 
            // lblLastname
            // 
            lblLastname.Anchor = AnchorStyles.None;
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(12, 164);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(95, 21);
            lblLastname.TabIndex = 5;
            lblLastname.Text = "Last Name *";
            // 
            // positionTxtbox
            // 
            positionTxtbox.Anchor = AnchorStyles.None;
            positionTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionTxtbox.Location = new Point(12, 242);
            positionTxtbox.Name = "positionTxtbox";
            positionTxtbox.Size = new Size(247, 27);
            positionTxtbox.TabIndex = 8;
            // 
            // lblPosition
            // 
            lblPosition.Anchor = AnchorStyles.None;
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.Location = new Point(12, 218);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(76, 21);
            lblPosition.TabIndex = 7;
            lblPosition.Text = "Position *";
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.BackColor = SystemColors.Highlight;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = SystemColors.ButtonHighlight;
            submitBtn.Location = new Point(63, 275);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(137, 32);
            submitBtn.TabIndex = 9;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.Anchor = AnchorStyles.None;
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeList.Location = new Point(266, 13);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(109, 21);
            lblEmployeeList.TabIndex = 10;
            lblEmployeeList.Text = "Employee List:";
            // 
            // table
            // 
            table.Anchor = AnchorStyles.None;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(266, 37);
            table.Name = "table";
            table.Size = new Size(501, 270);
            table.TabIndex = 11;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 320);
            Controls.Add(table);
            Controls.Add(lblEmployeeList);
            Controls.Add(submitBtn);
            Controls.Add(positionTxtbox);
            Controls.Add(lblPosition);
            Controls.Add(lastnameTxtbox);
            Controls.Add(lblLastname);
            Controls.Add(firstnameTxtbox);
            Controls.Add(lblFirstname);
            Controls.Add(employeeIDTxtbox);
            Controls.Add(lblEmployeeID);
            Controls.Add(lblAddEmployee);
            Name = "frmEmployeeDatabase";
            Text = "Employee Database";
            Load += frmEmployeeDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddEmployee;
        private Label lblEmployeeID;
        private TextBox employeeIDTxtbox;
        private TextBox firstnameTxtbox;
        private Label lblFirstname;
        private TextBox lastnameTxtbox;
        private Label lblLastname;
        private TextBox positionTxtbox;
        private Label lblPosition;
        private Button submitBtn;
        private Label lblEmployeeList;
        private DataGridView table;
    }
}
