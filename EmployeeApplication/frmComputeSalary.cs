using System;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        private PartTimeEmployee partTimeEmployee;

        public frmComputeSalary()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BtnComputeSalary_Click(object sender, EventArgs e)
        {
            #region -- Initialize First --
            partTimeEmployee = new PartTimeEmployee()
            {
                FirstName = TxtboxFirstname.Text,
                LastName = TxtboxLastname.Text,
                Department = TxtboxDepartment.Text,
                JobTitle = TxtboxJobTitle.Text
            };

            double ratePerHour = double.Parse(TxtboxRatePerHour.Text);
            int hoursWorked = int.Parse(TxtboxHoursWorked.Text);

            partTimeEmployee.computeSalary(hoursWorked, ratePerHour);
            #endregion

            #region -- Display to labels --
            LblFirstNameResult.Text = partTimeEmployee.FirstName;
            LblLastNameResult.Text = partTimeEmployee.LastName;
            LblBasicSalaryResult.Text = partTimeEmployee.BasicSalary.ToString("F2");
            #endregion
        }
    }
}
