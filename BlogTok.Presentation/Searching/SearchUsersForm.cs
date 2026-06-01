using BlogTok.Data.Enums;
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
        public SearchUsersForm()
        {
            InitializeComponent();
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
    }
}
