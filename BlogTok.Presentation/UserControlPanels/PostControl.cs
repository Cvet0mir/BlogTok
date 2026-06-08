using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogTok.Presentation.UserControlPanels
{
    public partial class PostControl : System.Windows.Forms.UserControl
    {
        public event EventHandler PostClicked;

        public PostControl()
        {
            InitializeComponent();

            this.Click += OnControlClicked;
            pictureBox1.Click += OnControlClicked;
            label3.Click += OnControlClicked;
            richTextBox1.Click += OnControlClicked;
        }

        public void OnControlClicked(object sender, EventArgs e)
        {
            PostClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PostControl_Load(object sender, EventArgs e)
        {

        }

        public string ImgPath
        {
            get => pictureBox1.ImageLocation;
            set => pictureBox1.ImageLocation = value;
        }
        public string Title
        {
            get => label3.Text;
            set => label3.Text = value;
        }
        public string Content
        {
            get => richTextBox1.Text;
            set => richTextBox1.Text = value;
        }
    }
}
