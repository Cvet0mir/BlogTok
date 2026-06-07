using BlogTok.Controllers;
using BlogTok.Data.Models;
using BlogTok.Presentation.PostForms;
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
    public partial class OtherProfileForm : Form
    {
        private readonly UserController _controller;
        private User _user;

        public OtherProfileForm(User user)
        {
            InitializeComponent();

            _user = user;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchUsersForm searchUsersForm = new();
            searchUsersForm.ShowDialog();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllPostsForm allPostsForm = new(user: _user);
            allPostsForm.ShowDialog();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new();
            profileForm.ShowDialog();

            this.Close();
        }

        private async void OtherProfileForm_Load(object sender, EventArgs e)
        {
            label2.Text = _user.FirstName + " " + _user.Surname;
            button1.Text = (await _controller.GetFollowersAsync(_user.Id)).Count.ToString();
            button2.Text = (await _controller.GetFollowingAsync(_user.Id)).Count.ToString();
            button3.Text = _user.FirstName + "'s posts";

            if (string.IsNullOrWhiteSpace(_user.ProfilePic))
            {
                pictureBox1.ImageLocation = _user.ProfilePic;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            string res = await _controller.DeleteUserAsync(UserSession.CurrentUser, _user.Id);

            if (res == "User deleted")
            {
                MessageBox.Show(res, "User Deletion Success");

                AdminHomePage adminHomePage = new();
                adminHomePage.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(res, "User Deletion Fail");
            }
        }
    }
}
