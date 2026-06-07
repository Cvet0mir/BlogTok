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
    public partial class AddPost : Form
    {
        PostController _controller;
        private string _imgPath;

        public AddPost()
        {
            InitializeComponent();

            _controller = new();
            _imgPath = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Title = "Choose a post picture";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string content = richTextBox1.Text;
            string imgPath = pictureBox1.ImageLocation;

            string result = await _controller.CreatePostAsync(UserSession.CurrentUser.Id, title, content, imgPath);

            if (result == "Post created successfully")
            {
                MessageBox.Show("Post created successfully!", "Success");
                ProfileForm profileForm = new();
                profileForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new();
            profileForm.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Title = "Choose a picture for the post";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                _imgPath = imagePath;

                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
