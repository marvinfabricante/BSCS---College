using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class StudentRegistrationApplication : Form
    {
        public StudentRegistrationApplication()
        {
            InitializeComponent();
        }

        #region -- Overloaded Methods --
        /* Dalawa nalang ginawa ko sir, parehas lang naman yung dalawang message box sa output eh */
        private static void StudentInfo(string firstname, string middlename, string lastname, string program)
        {
            MessageBox.Show($"Student name: {firstname} {middlename} {lastname}\n" +
                $"Program: {program}");
        }

        /* Bali dito sir migs, naka output na lahat */
        private static void StudentInfo(string firstname, string middlename, string lastname, string gender, string birthday,  string program)
        {
            MessageBox.Show($"Student name: {firstname} {middlename} {lastname}\n" +
                $"Gender: {gender}\n" +
                $"Date of birth: {birthday}\n" +
                $"Program: {program}");
        }
        #endregion

        private void StudentRegistrationApplication_Load(object sender, EventArgs e)
        {
            #region -- Birthday Comboboxes --
            for (int i = 0; i <= 31; i++)
            {
                dayCombobox.Items.Add(i);
            }

            List<string> months = new List<string>()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            foreach (string month in months)
            {
                monthCombobox.Items.Add(month);
            }

            for (int i = 2024; i >= 1900; i--)
            {
                yearCombobox.Items.Add(i);
            }
            #endregion

            #region -- Program Combobox --
            List<string> listOfPrograms = new List<string>()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Computer Engineering",
                "Bachelor of Science in Accountancy",
                "Bachelor of Science in Business Administration",
                "Bachelor of Science in Hospitality Management",
                "Bachelor of Arts in Psychology",
                "Bachelor of Arts in Communication",
                "Bachelor of Arts in Multimedia Arts",
                "Bachelor of Science in Criminology",
                "Bachelor of Science in Marine Transportation"
            };

            foreach (string program in listOfPrograms)
            {
                programCombobox.Items.Add(program);
            }
            #endregion
        }

        private void registerStudentBtn_Click(object sender, EventArgs e)
        {
            #region -- Initializing the values --
            string lastname = lastnameTxtbox.Text;
            string firstname = firstnameTxtbox.Text;
            string middlename = middlenameTxtbox.Text;

            string gender = maleRadiobtn.Checked ? "Male" : "Female";
            string birthday = $"{dayCombobox.SelectedItem}/{monthCombobox.SelectedItem}/{yearCombobox.SelectedItem}";
            string program = $"{programCombobox.SelectedItem}";

            StudentInfo(firstname, middlename, lastname, program);
            StudentInfo(firstname, middlename, lastname, gender, birthday, program);
            #endregion
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            #region -- Browse all sorts of images here --
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                /* Bali sir migs, tatanggapin lang neto ay mga images lamang, nothing else */ 
                openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.tif;*.ico;*.webp;*.jfif;*.svg|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = selectedImage;

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            #endregion
        }
    }
}
