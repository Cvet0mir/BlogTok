// Auto-generated minimal designer for PostControl to provide InitializeComponent
// Adjust sizes and added controls as needed in your Designer/IDE.
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlogTok.Presentation.UserControlPanels
{
    public partial class PostControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// InitializeComponent implementation created to satisfy compiler.
        /// Add designer-managed controls here or let the WinForms designer regenerate this file.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PostControl));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(199, 21);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 3;
            label3.Text = "Title";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(199, 61);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(317, 163);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // PostControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PostControl";
            Size = new Size(520, 229);
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}
