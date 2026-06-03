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
    public partial class ProfileForm : Form
    {
        // pls helppppp 😭😭😭

        private UserController _controller;

        public ProfileForm()
        {
            InitializeComponent();

            _controller = new();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddPost addPostForm = new();
            addPostForm.ShowDialog();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchUsersForm searchUsersForm = new();
            searchUsersForm.ShowDialog();

            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserSession.CurrentUser = null;

            LogInScreen loginForm = new();
            loginForm.ShowDialog();

            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditUserForm editUserPage = new();
            editUserPage.ShowDialog();

            this.Close();
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {

            button1.Text = (await _controller
                .GetFollowersAsync(UserSession.CurrentUser.Id))
                .Count
                .ToString();
            button2.Text = (await _controller
                .GetFollowersAsync(UserSession.CurrentUser.Id))
                .Count
                .ToString();
            label2.Text = UserSession.CurrentUser.FirstName + " " + UserSession.CurrentUser.Surname;
        }
    }
}
