using BlogTok.Controllers;
using Microsoft.IdentityModel.Tokens;

namespace BlogTok.Presentation
{
    public partial class Form1 : Form
    {
        //private readonly CommentController _commentController;
        //private readonly CommentReactionController _commentReactionController;
        //private readonly PostController _postController;
        private readonly UserController _userController;
        //private readonly ReactionController _reactionController;
        private string _profilePic = "";

        public Form1()
        {
            InitializeComponent();

            //_commentController = new();
            //_commentReactionController = new();
            //_postController = new();
            _userController = new();
            //_reactionController = new();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string email = textBox4.Text;
            string password = textBox3.Text;
            string firstName = textBox2.Text;
            string lastName = textBox1.Text;
            DateTime birthDate = dateTimePicker1.Value;

            var res = await _userController.RegisterAsync(email, password, firstName, lastName, birthDate, _profilePic);
            if (res == "User registered successfully")
            {
                MessageBox.Show("User registered successfully! Now, sign into to your new account", "Registration Successfull");

                LogInScreen logInScreen = new();
                logInScreen.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(res, "Registration Unsuccessfull");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Title = "Choose a profile picture";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                _profilePic = imagePath;

                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            LogInScreen logInScreen = new();
            logInScreen.ShowDialog();
            this.Close();
        }
    }
}
