using BlogTok.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogTok.Presentation
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserSession.CurrentUser = null;

            LogInScreen logInPage = new();
            logInPage.ShowDialog();

            this.Close();
        }
    }
}
