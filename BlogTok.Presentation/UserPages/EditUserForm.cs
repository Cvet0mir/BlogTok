using BlogTok.Controllers;
using BlogTok.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogTok.Presentation
{
    public partial class EditUserForm : Form
    {
        private readonly UserController _userController;
        private string _profilePic = "";

        public EditUserForm()
        {
            InitializeComponent();

            _userController = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Title = "Choose a new profile picture";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                _profilePic = imagePath;

                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            textBox2.Text = UserSession.CurrentUser.FirstName;
            textBox1.Text = UserSession.CurrentUser.Surname;

            dateTimePicker1.Value = UserSession.CurrentUser.BirthDate;
            if (!string.IsNullOrWhiteSpace(UserSession.CurrentUser.ProfilePic))
            {
                pictureBox1.ImageLocation = UserSession.CurrentUser.ProfilePic;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            string surname = textBox1.Text;
            DateTime birthDate = dateTimePicker1.Value;
            if (!string.IsNullOrWhiteSpace(UserSession.CurrentUser.ProfilePic))
            {
                pictureBox1.ImageLocation = UserSession.CurrentUser.ProfilePic;
            }

            string res = await _userController.UpdateProfileAsync(UserSession.CurrentUser.Id, firstName, surname, _profilePic, birthDate);
            if (res == "Profile updated")
            {
                UserSession.CurrentUser = await _userController.GetProfileAsync(UserSession.CurrentUser.Id);
                MessageBox.Show(res, "Profile Update Success");

                ProfileForm profileForm = new();
                profileForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(res, "Profile Update Fail");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new();
            profileForm.ShowDialog();

            this.Close();
        }
    }
}
