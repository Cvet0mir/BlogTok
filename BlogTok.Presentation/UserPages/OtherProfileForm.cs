using BlogTok.Controllers;
using BlogTok.Data.Enums;
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

            _controller = new();
            _user = user;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchUsersForm searchUsersForm = new();
            searchUsersForm.ShowDialog();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllPostsForm allPostsForm = new(user: _user);
            allPostsForm.ShowDialog();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.Role == RoleType.User)
            {
                this.Hide();
                ProfileForm profileForm = new();
                profileForm.ShowDialog();
            }
            else
            {
                this.Hide();
                AdminHomePage adminHomePage = new();
                adminHomePage.ShowDialog();
            }

            this.Close();
        }

        private async void OtherProfileForm_Load(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.Role == RoleType.Admin)
            {
                button4.Visible = false;
                button7.Visible = true;
            }

            label2.Text = _user.FirstName + " " + _user.Surname;
            button1.Text = (await _controller
                .GetFollowersAsync(_user.Id))
                .Count
                .ToString();
            button2.Text = (await _controller
                .GetFollowingAsync(_user.Id))
                .Count
                .ToString();
            button3.Text = _user.FirstName + "'s posts";

            if (!string.IsNullOrWhiteSpace(_user.ProfilePic))
            {
                pictureBox1.ImageLocation = _user.ProfilePic;
            }

            List<User> followers = await _controller.GetFollowersAsync(_user.Id);
            if (followers.Select(f => f.Id).Contains(UserSession.CurrentUser.Id))
                button4.Text = "Unfollow";
            else
                button4.Text = "Follow";
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var followings = await _controller.GetFollowingAsync(UserSession.CurrentUser.Id);
            if (!followings.Select(f => f.Id).Contains(_user.Id))
            {
                string res = await _controller.FollowAsync(UserSession.CurrentUser.Id, _user.Id);

                if (res == "Followed successfully")
                {
                    _user = await _controller.GetProfileAsync(_user.Id);
                    MessageBox.Show(res, "Follow Success");
                    button1.Text = (await _controller.GetFollowersAsync(_user.Id)).Count.ToString();
                    button4.Text = "Unfollow";
                }
                else
                {
                    MessageBox.Show(res, "Follow Fail");
                }
            }
            else
            {
                string res = await _controller.UnfollowAsync(UserSession.CurrentUser.Id, _user.Id);

                if (res == "Unfollowed successfully")
                {
                    _user = await _controller.GetProfileAsync(_user.Id);
                    MessageBox.Show(res, "Unfollow Success");
                    button1.Text = (await _controller.GetFollowersAsync(_user.Id)).Count.ToString();
                    button4.Text = "Follow";
                }
                else
                {
                    MessageBox.Show(res, "Unfollow Fail");
                }
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            string res = await _controller.DeleteUserAsync(UserSession.CurrentUser, _user.Id);

            if (res == "User deleted")
            {
                MessageBox.Show(res, "User Deletion Success");

                this.Hide();
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
