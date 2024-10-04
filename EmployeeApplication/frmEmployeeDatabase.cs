using System.Data;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        private DataTable employeeTable;

        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            employeeTable = new DataTable();

            employeeTable.Columns.Add("Id", typeof(string));
            employeeTable.Columns.Add("Firstname", typeof(string));
            employeeTable.Columns.Add("Lastname", typeof(string));
            employeeTable.Columns.Add("Position", typeof(string));

            table.DataSource = employeeTable;

            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeIDTxtbox.Text) ||
                string.IsNullOrWhiteSpace(firstnameTxtbox.Text) ||
                string.IsNullOrWhiteSpace(lastnameTxtbox.Text) ||
                string.IsNullOrWhiteSpace(positionTxtbox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Employee employee = new Employee(
                employeeIDTxtbox.Text,
                firstnameTxtbox.Text,
                lastnameTxtbox.Text,
                positionTxtbox.Text
            );

            employeeTable.Rows.Add(employee.EmployeeId, employee.FirstName, employee.Lastname, employee.Position);
        }
    }
}
