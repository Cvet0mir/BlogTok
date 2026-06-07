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

namespace BlogTok.Presentation
{
    public partial class SearchUsersForm : Form
    {
        private readonly UserController _controller;

        public SearchUsersForm()
        {
            InitializeComponent();

            _controller = new();
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
                AdminHomePage adminPanelForm = new();
                adminPanelForm.ShowDialog();
            }

            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<User> users = await _controller.SearchUsersAsync(textBox3.Text);

            //if (radioButton1.Checked)
            //{
            //    users = await _controller.SearchUsersAsync(textBox3.Text);
            //}
            //else
            if (radioButton2.Checked)
            {
                users = users
                    .Where(u => UserSession.CurrentUser.Following?
                        .Any(f => f.FollowingId == u.Id) ?? false
                    ).ToList();
            }
            else if (radioButton3.Checked)
            {
                users = users
                    .Where(u => UserSession.CurrentUser.Followers?
                        .Any(f => f.FollowerId == u.Id) ?? false
                    ).ToList();
            }

            foreach (User user in users)
            {
                ProfileControl profileControl = new(user);
                flowLayoutPanel1.Controls.Add(profileControl);
            }
        }

        private void SearchUsersForm_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
