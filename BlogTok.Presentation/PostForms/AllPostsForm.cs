using BlogTok.Controllers;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Presentation.UserControlPanels;
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

namespace BlogTok.Presentation.PostForms
{
    public partial class AllPostsForm : Form
    {
        private PostController _controller;
        private int _choice;
        private User _user;

        public AllPostsForm(int choice = 0, User user = null)
        {
            InitializeComponent();

            _controller = new();
            _choice = choice;
            _user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.Role == RoleType.User)
            {
                ProfileForm profileForm = new();
                profileForm.ShowDialog();
            }
            else
            {
                AdminHomePage adminHomePage = new();
                adminHomePage.ShowDialog();
            }

            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Post> posts = new();

            if (radioButton1.Checked)
            {
                posts = await _controller.GetFeedAsync();
            }
            else if (radioButton3.Checked)
            {
                posts = await _controller.GetMostLikedPostsAsync();
            }
            else
            {
                posts = await _controller.GetFeedAsync();
            }

            posts = posts.Where(x => (x.User.FirstName + " " + x.User.Surname)
            .ToLower()
            .Contains(
                textBox3.Text.ToLower())
            ).ToList();

            if (radioButton6.Checked)
            {
                posts = posts.Where(x => x.Comments.Any(c => c.UserId == UserSession.CurrentUser.Id)).ToList();
            }
            else if (radioButton7.Checked)
            {
                posts = posts.Where(x => x.Reactions.Any(r => r.UserId == UserSession.CurrentUser.Id && r.Emotion == ReactionType.Like)).ToList();
            }
            else if (radioButton8.Checked)
            {
                posts = posts.Where(x => x.UserId == UserSession.CurrentUser.Id).ToList();
            }

            foreach (Post post in posts)
            {
                PostControl control = new();

                control.Title = post.Title;
                control.Content = post.Description;
                control.ImgPath = post.Picture;
                control.Tag = post;

                control.PostClicked += PostControl_PostClicked;
                flowLayoutPanel1.Controls.Add(control);
            }
        }
        private void PostControl_PostClicked(object sender, EventArgs e)
        {
            PostControl control = (PostControl)sender;
            Post post = (Post)control.Tag;

            PostDetailsForm detailsForm = new(post);
            detailsForm.ShowDialog();
        }

        private void AllPostsForm_Load(object sender, EventArgs e)
        {
            if (_choice == 1)
            {
                radioButton8.Checked = true;
            }
            else if (_choice == 2)
            {
                radioButton7.Checked = true;
            }
            else if (_choice == 3)
            {
                radioButton6.Checked = true;
            }
            if (_user != null)
            {
                textBox3.Text = _user.FirstName + " " + _user.Surname;
            }

            button1_Click(sender, e);
        }
    }
}
