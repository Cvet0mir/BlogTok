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
        public ProfileForm()
        {
            InitializeComponent();
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
    }
}
