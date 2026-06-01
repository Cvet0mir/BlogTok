using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Presentation.PostForms;
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
    public partial class PostDetailsForm : Form
    {
        private readonly Post _post;

        public PostDetailsForm(Post post)
        {
            InitializeComponent();

            _post = post;
            LoadPost();
        }

        private void LoadPost()
        {
            label2.Text = _post.Title;
            richTextBox1.Text = _post.Description;
            pictureBox1.ImageLocation = _post.Picture;
            label5.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Like).ToString();
            label1.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Dislike).ToString();
            label3.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Funny).ToString();
            label4.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Sad).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllPostsForm allPostsForm = new();
            allPostsForm.ShowDialog();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _post
        }
    }
}
