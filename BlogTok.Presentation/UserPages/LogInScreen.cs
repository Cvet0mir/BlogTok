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
    public partial class LogInScreen : Form
    {
        private readonly UserController _userController;
        public LogInScreen()
        {
            InitializeComponent();

            _userController = new();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 reigstrationPage = new();
            reigstrationPage.ShowDialog();
            this.Close();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string email = textBox4.Text;
            string password = textBox3.Text;

            var res = await _userController.LoginAsync(email, password);
            if (res.Success)
            {
                UserSession.CurrentUser = res.User;
                MessageBox.Show(res.Message, "Log in Success");

                ProfileForm profileForm = new();
                profileForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Message, "Log in Fail");
            }
        }
    }
}
