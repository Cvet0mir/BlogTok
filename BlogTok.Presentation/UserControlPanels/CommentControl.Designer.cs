namespace BlogTok.Presentation.UserControlPanels
{
    partial class CommentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentControl));
            pictureBox1 = new PictureBox();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.GreenYellow;
            label6.Location = new Point(57, 10);
            label6.Name = "label6";
            label6.Size = new Size(0, 18);
            label6.TabIndex = 21;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(63, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(311, 82);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Font = new Font("SimSun", 10F);
            button2.Location = new Point(6, 58);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(24, 24);
            button2.TabIndex = 24;
            button2.Text = "👍";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("SimSun", 10F);
            button1.Location = new Point(33, 86);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
            button1.TabIndex = 25;
            button1.Text = "😭";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Font = new Font("SimSun", 10F);
            button3.Location = new Point(6, 86);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(24, 24);
            button3.TabIndex = 26;
            button3.Text = "😂";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("SimSun", 10F);
            button4.Location = new Point(33, 58);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(24, 24);
            button4.TabIndex = 27;
            button4.Text = "👎";
            button4.UseVisualStyleBackColor = false;
            // 
            // CommentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Name = "CommentControl";
            Size = new Size(377, 129);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}
