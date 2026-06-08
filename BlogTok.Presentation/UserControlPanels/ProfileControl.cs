using BlogTok.Data.Models;
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
using System.Windows.Forms.VisualStyles;

namespace BlogTok.Presentation.UserControlPanels
{
    public partial class ProfileControl : UserControl
    {
        private readonly User _user;

        public ProfileControl(User user)
        {
            InitializeComponent();

            _user = user;
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            label6.Text = _user.FirstName + " " + _user.Surname;
            if (!string.IsNullOrWhiteSpace(_user.ProfilePic))
            {
                pictureBox1.ImageLocation = _user.ProfilePic;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.Id == _user.Id)
            {
                ProfileForm profileForm = new();
                profileForm.ShowDialog();
            }
            else
            {
                OtherProfileForm otherProfileForm = new(_user);
                otherProfileForm.ShowDialog();
            }
        }
    }
}
