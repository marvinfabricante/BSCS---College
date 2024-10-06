using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string lastname = lastnameTxtbox.Text;
            string firstname = firstnameTxtbox.Text;
            string middlename = middlenameTxtbox.Text;
            string emailaddress = emailAddressTxtbox.Text;
            string phonenumber = phoneNumberTxtbox.Text;

            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();

                    string connectionString = "Data Source=MARVIN\\SQLEXPRESS01;Initial Catalog=UserData;Integrated Security=True;"; // Update with your connection string

                    try
                    {
                        await InsertUserDataAsync(connectionString, firstname, middlename, lastname, emailaddress, phonenumber, imageBytes);
                        MessageBox.Show("Data saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an image before submitting.");
            }

            UserControl1 u1 = new UserControl1();
            u1.Show();
        }

        private async Task InsertUserDataAsync(string connectionString, string firstname, string middlename, string lastname, string emailaddress, string phonenumber, byte[] imageBytes)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserData (FirstName, MiddleName, LastName, EmailAddress, PhoneNumber, ProfileImage) " +
                               "VALUES (@FirstName, @MiddleName, @LastName, @EmailAddress, @PhoneNumber, @ProfileImage)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@MiddleName", middlename);
                    command.Parameters.AddWithValue("@LastName", lastname);
                    command.Parameters.AddWithValue("@EmailAddress", emailaddress);
                    command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                    command.Parameters.AddWithValue("@ProfileImage", imageBytes);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff;*.jfif|All Files|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        Image selectedImage = Image.FromFile(filePath);
                        pictureBox1.Image = selectedImage;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }
    }
}
