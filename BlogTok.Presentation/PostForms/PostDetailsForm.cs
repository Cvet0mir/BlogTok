using BlogTok.Controllers;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Presentation.PostForms;
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
    public partial class PostDetailsForm : Form
    {
        private readonly ReactionController _controller;
        private readonly PostController _postController;
        private readonly Post _post;

        public PostDetailsForm(Post post)
        {
            InitializeComponent();

            _controller = new();
            _postController = new();

            _post = post;
            LoadPost();
        }

        private void LoadPost()
        {
            label2.Text = _post.Title;
            richTextBox1.Text = _post.Description;

            if (!string.IsNullOrWhiteSpace(_post.Picture))
            {
                pictureBox1.ImageLocation = _post.Picture;
            }
            label5.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Like).ToString();
            label1.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Dislike).ToString();
            label3.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Funny).ToString();
            label4.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Sad).ToString();
            label6.Text = _post.User.FirstName + " " + _post.User.Surname;
            if (!string.IsNullOrWhiteSpace(_post.User.ProfilePic))
            {
                pictureBox2.ImageLocation = _post.User.ProfilePic;
            }

            if (_post.UserId == UserSession.CurrentUser.Id || UserSession.CurrentUser.Role == RoleType.Admin)
            {
                button6.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllPostsForm allPostsForm = new();
            allPostsForm.ShowDialog();

            this.Close();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _controller.ReactToPostAsync(UserSession.CurrentUser.Id, _post.Id, ReactionType.Dislike), "Reaction to post");

            label5.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Like).ToString();
            label1.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Dislike).ToString();
            label3.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Funny).ToString();
            label4.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Sad).ToString();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _controller.ReactToPostAsync(UserSession.CurrentUser.Id, _post.Id, ReactionType.Like), "Reaction to post");

            label5.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Like).ToString();
            label1.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Dislike).ToString();
            label3.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Funny).ToString();
            label4.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Sad).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PostDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string res = await _postController.DeletePostAsync(_post.Id, UserSession.CurrentUser.Id);
            if (res == "Post deleted")
            {
                MessageBox.Show(res, "Post Deletion Success");

                AllPostsForm allPostsForm = new();
                allPostsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(res, "Post Deletion Failed");
            }


            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OtherProfileForm otherProfileForm = new(_post.User);
            otherProfileForm.ShowDialog();

            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OtherProfileForm otherProfileForm = new(_post.User);
            otherProfileForm.ShowDialog();

            this.Close();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _controller.ReactToPostAsync(UserSession.CurrentUser.Id, _post.Id, ReactionType.Funny), "Reaction to post");

            label5.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Like).ToString();
            label1.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Dislike).ToString();
            label3.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Funny).ToString();
            label4.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Sad).ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _controller.ReactToPostAsync(UserSession.CurrentUser.Id, _post.Id, ReactionType.Sad), "Reaction to post");

            label5.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Like).ToString();
            label1.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Dislike).ToString();
            label3.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Funny).ToString();
            label4.Text = _post.Reactions.Count(x => x.Emotion == ReactionType.Sad).ToString();
        }
    }
}
