using BlogTok.Controllers;
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

namespace BlogTok.Presentation.PostForms
{
    public partial class AddComment : Form
    {
        private readonly CommentController _commentController;
        private readonly PostController _postController;
        private Post _post;

        public AddComment(Post post)
        {
            InitializeComponent();

            _commentController = new();
            _postController = new();
            _post = post;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string res = await _commentController.CreateCommentAsync(UserSession.CurrentUser.Id, _post.Id, richTextBox1.Text);

            if (res == "Comment added")
            {
                _post = await _postController.GetPostAsync(_post.Id);

                this.Hide();
                PostDetailsForm postDetailsForm = new(_post);
                postDetailsForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(res, "Comment Addition Fail");
            }
        }

        private void AddComment_Load(object sender, EventArgs e)
        {

        }
    }
}
