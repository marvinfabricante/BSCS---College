namespace StudentRegistrationApplication
{
    partial class StudentRegistrationApplication
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
            lblTitle = new Label();
            lblLastname = new Label();
            lastnameTxtbox = new TextBox();
            firstnameTxtbox = new TextBox();
            lblFirstname = new Label();
            middlenameTxtbox = new TextBox();
            lblMiddlename = new Label();
            lblGender = new Label();
            maleRadiobtn = new RadioButton();
            femaleRadiobtn = new RadioButton();
            lblDateofbirth = new Label();
            dayCombobox = new ComboBox();
            monthCombobox = new ComboBox();
            yearCombobox = new ComboBox();
            lblProgramToApply = new Label();
            programCombobox = new ComboBox();
            registerStudentBtn = new Button();
            pictureBox1 = new PictureBox();
            browseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(2, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Registration Form";
            // 
            // lblLastname
            // 
            lblLastname.Anchor = AnchorStyles.None;
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(12, 54);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(94, 21);
            lblLastname.TabIndex = 1;
            lblLastname.Text = "Last name *";
            // 
            // lastnameTxtbox
            // 
            lastnameTxtbox.Anchor = AnchorStyles.None;
            lastnameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnameTxtbox.Location = new Point(12, 77);
            lastnameTxtbox.Name = "lastnameTxtbox";
            lastnameTxtbox.Size = new Size(262, 27);
            lastnameTxtbox.TabIndex = 2;
            // 
            // firstnameTxtbox
            // 
            firstnameTxtbox.Anchor = AnchorStyles.None;
            firstnameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnameTxtbox.Location = new Point(12, 130);
            firstnameTxtbox.Name = "firstnameTxtbox";
            firstnameTxtbox.Size = new Size(262, 27);
            firstnameTxtbox.TabIndex = 4;
            // 
            // lblFirstname
            // 
            lblFirstname.Anchor = AnchorStyles.None;
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstname.Location = new Point(12, 107);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(96, 21);
            lblFirstname.TabIndex = 3;
            lblFirstname.Text = "First name *";
            // 
            // middlenameTxtbox
            // 
            middlenameTxtbox.Anchor = AnchorStyles.None;
            middlenameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middlenameTxtbox.Location = new Point(12, 183);
            middlenameTxtbox.Name = "middlenameTxtbox";
            middlenameTxtbox.Size = new Size(262, 27);
            middlenameTxtbox.TabIndex = 6;
            // 
            // lblMiddlename
            // 
            lblMiddlename.Anchor = AnchorStyles.None;
            lblMiddlename.AutoSize = true;
            lblMiddlename.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiddlename.Location = new Point(12, 160);
            lblMiddlename.Name = "lblMiddlename";
            lblMiddlename.Size = new Size(117, 21);
            lblMiddlename.TabIndex = 5;
            lblMiddlename.Text = "Middle name *";
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.None;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(12, 213);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(75, 21);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender *";
            // 
            // maleRadiobtn
            // 
            maleRadiobtn.Anchor = AnchorStyles.None;
            maleRadiobtn.AutoSize = true;
            maleRadiobtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maleRadiobtn.Location = new Point(84, 216);
            maleRadiobtn.Name = "maleRadiobtn";
            maleRadiobtn.Size = new Size(60, 24);
            maleRadiobtn.TabIndex = 8;
            maleRadiobtn.TabStop = true;
            maleRadiobtn.Text = "Male";
            maleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // femaleRadiobtn
            // 
            femaleRadiobtn.Anchor = AnchorStyles.None;
            femaleRadiobtn.AutoSize = true;
            femaleRadiobtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            femaleRadiobtn.Location = new Point(150, 216);
            femaleRadiobtn.Name = "femaleRadiobtn";
            femaleRadiobtn.Size = new Size(75, 24);
            femaleRadiobtn.TabIndex = 9;
            femaleRadiobtn.TabStop = true;
            femaleRadiobtn.Text = "Female";
            femaleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // lblDateofbirth
            // 
            lblDateofbirth.Anchor = AnchorStyles.None;
            lblDateofbirth.AutoSize = true;
            lblDateofbirth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateofbirth.Location = new Point(12, 238);
            lblDateofbirth.Name = "lblDateofbirth";
            lblDateofbirth.Size = new Size(107, 20);
            lblDateofbirth.TabIndex = 10;
            lblDateofbirth.Text = "Date of birth *";
            // 
            // dayCombobox
            // 
            dayCombobox.Anchor = AnchorStyles.None;
            dayCombobox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dayCombobox.FormattingEnabled = true;
            dayCombobox.Location = new Point(16, 262);
            dayCombobox.Name = "dayCombobox";
            dayCombobox.Size = new Size(62, 28);
            dayCombobox.TabIndex = 11;
            dayCombobox.Text = "-Day-";
            // 
            // monthCombobox
            // 
            monthCombobox.Anchor = AnchorStyles.None;
            monthCombobox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCombobox.FormattingEnabled = true;
            monthCombobox.Location = new Point(84, 262);
            monthCombobox.Name = "monthCombobox";
            monthCombobox.Size = new Size(100, 28);
            monthCombobox.TabIndex = 12;
            monthCombobox.Text = "-Month-";
            // 
            // yearCombobox
            // 
            yearCombobox.Anchor = AnchorStyles.None;
            yearCombobox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearCombobox.FormattingEnabled = true;
            yearCombobox.Location = new Point(190, 262);
            yearCombobox.Name = "yearCombobox";
            yearCombobox.Size = new Size(77, 28);
            yearCombobox.TabIndex = 13;
            yearCombobox.Text = "-Year-";
            // 
            // lblProgramToApply
            // 
            lblProgramToApply.Anchor = AnchorStyles.None;
            lblProgramToApply.AutoSize = true;
            lblProgramToApply.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgramToApply.Location = new Point(12, 290);
            lblProgramToApply.Name = "lblProgramToApply";
            lblProgramToApply.Size = new Size(140, 20);
            lblProgramToApply.TabIndex = 14;
            lblProgramToApply.Text = "Program to apply *";
            // 
            // programCombobox
            // 
            programCombobox.Anchor = AnchorStyles.None;
            programCombobox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCombobox.FormattingEnabled = true;
            programCombobox.Location = new Point(16, 313);
            programCombobox.Name = "programCombobox";
            programCombobox.Size = new Size(305, 28);
            programCombobox.TabIndex = 15;
            programCombobox.Text = "-Select program-";
            // 
            // registerStudentBtn
            // 
            registerStudentBtn.Anchor = AnchorStyles.None;
            registerStudentBtn.BackColor = Color.Crimson;
            registerStudentBtn.FlatStyle = FlatStyle.Flat;
            registerStudentBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerStudentBtn.ForeColor = SystemColors.ButtonHighlight;
            registerStudentBtn.Location = new Point(16, 347);
            registerStudentBtn.Name = "registerStudentBtn";
            registerStudentBtn.Size = new Size(168, 34);
            registerStudentBtn.TabIndex = 16;
            registerStudentBtn.Text = "Register Student";
            registerStudentBtn.UseVisualStyleBackColor = false;
            registerStudentBtn.Click += registerStudentBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(301, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 204);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // browseBtn
            // 
            browseBtn.Anchor = AnchorStyles.None;
            browseBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browseBtn.Location = new Point(348, 264);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(110, 26);
            browseBtn.TabIndex = 18;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // StudentRegistrationApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 395);
            Controls.Add(browseBtn);
            Controls.Add(pictureBox1);
            Controls.Add(registerStudentBtn);
            Controls.Add(programCombobox);
            Controls.Add(lblProgramToApply);
            Controls.Add(yearCombobox);
            Controls.Add(monthCombobox);
            Controls.Add(dayCombobox);
            Controls.Add(lblDateofbirth);
            Controls.Add(femaleRadiobtn);
            Controls.Add(maleRadiobtn);
            Controls.Add(lblGender);
            Controls.Add(middlenameTxtbox);
            Controls.Add(lblMiddlename);
            Controls.Add(firstnameTxtbox);
            Controls.Add(lblFirstname);
            Controls.Add(lastnameTxtbox);
            Controls.Add(lblLastname);
            Controls.Add(lblTitle);
            Name = "StudentRegistrationApplication";
            Text = "Student Registration";
            Load += StudentRegistrationApplication_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLastname;
        private TextBox lastnameTxtbox;
        private TextBox firstnameTxtbox;
        private Label lblFirstname;
        private TextBox middlenameTxtbox;
        private Label lblMiddlename;
        private Label lblGender;
        private RadioButton maleRadiobtn;
        private RadioButton femaleRadiobtn;
        private Label lblDateofbirth;
        private ComboBox dayCombobox;
        private ComboBox monthCombobox;
        private ComboBox yearCombobox;
        private Label lblProgramToApply;
        private ComboBox programCombobox;
        private Button registerStudentBtn;
        private PictureBox pictureBox1;
        private Button browseBtn;
    }
}
