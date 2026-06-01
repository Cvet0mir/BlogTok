using BlogTok.Controllers;
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
    public partial class UserJsonAddForm : Form
    {
        UserController _controller;
        public UserJsonAddForm()
        {
            InitializeComponent();
            _controller = new();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select JSON File";
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            string jsonPath = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                jsonPath = openFileDialog.FileName;
            }

            string res = await _controller.ImportUsersFromJsonAsync(jsonPath);
            if (res == "Users imported successfully")
            {
                MessageBox.Show("Users imported successfully!", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show(res, "Error");
            }
        }
    }
}
