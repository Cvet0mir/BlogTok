using BlogTok.Controllers;
using BlogTok.Data.Enums;
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

namespace BlogTok.Presentation.UserControlPanels
{
    public partial class CommentControl : UserControl
    {
        private readonly CommentReactionController _reactionController;
        private Comment _comment;
        private int _clickCount;

        public CommentControl(Comment comment)
        {
            InitializeComponent();

            _reactionController = new();
            _comment = comment;
            _clickCount = 0;
        }

        private void CommentControl_Load(object sender, EventArgs e)
        {
            label6.Text = _comment.User.FirstName + " " + _comment.User.Surname;
            if (!string.IsNullOrWhiteSpace(_comment.User.ProfilePic))
            {
                pictureBox1.ImageLocation = _comment.User.ProfilePic;
            }

            richTextBox1.Text = _comment.Content;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (_clickCount == 0)
            {
                MessageBox.Show(await _reactionController.ReactToCommentAsync(UserSession.CurrentUser.Id, _comment.Id, ReactionType.Like), "Reaction to comment");
                _clickCount++;

                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
            }
            else
            {
                MessageBox.Show(await _reactionController.UnreactCommentAsync(UserSession.CurrentUser.Id, _comment.Id), "Reaction removed");
                _clickCount = 0;

                button3.Visible = true;
                button4.Visible = true;
                button1.Visible = true;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (_clickCount == 0)
            {
                MessageBox.Show(await _reactionController.ReactToCommentAsync(UserSession.CurrentUser.Id, _comment.Id, ReactionType.Dislike), "Reaction to comment");
                _clickCount++;

                button3.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
            }
            else
            {
                MessageBox.Show(await _reactionController.UnreactCommentAsync(UserSession.CurrentUser.Id, _comment.Id), "Reaction removed");
                _clickCount = 0;

                button3.Visible = true;
                button2.Visible = true;
                button1.Visible = true;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (_clickCount == 0)
            {
                MessageBox.Show(await _reactionController.ReactToCommentAsync(UserSession.CurrentUser.Id, _comment.Id, ReactionType.Funny), "Reaction to comment");
                _clickCount++;

                button2.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
            }
            else
            {
                MessageBox.Show(await _reactionController.UnreactCommentAsync(UserSession.CurrentUser.Id, _comment.Id), "Reaction removed");
                _clickCount = 0;

                button2.Visible = true;
                button4.Visible = true;
                button1.Visible = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_clickCount == 0)
            {
                MessageBox.Show(await _reactionController.ReactToCommentAsync(UserSession.CurrentUser.Id, _comment.Id, ReactionType.Sad), "Reaction to comment");
                _clickCount++;

                button3.Visible = false;
                button4.Visible = false;
                button2.Visible = false;
            }
            else
            {
                MessageBox.Show(await _reactionController.UnreactCommentAsync(UserSession.CurrentUser.Id, _comment.Id), "Reaction removed");
                _clickCount = 0;

                button3.Visible = true;
                button4.Visible = true;
                button2.Visible = true;
            }
        }
    }
}
