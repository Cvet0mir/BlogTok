namespace BlogTok.Presentation
{
    partial class AddPost
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPost));
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(456, 27);
            label2.Name = "label2";
            label2.Size = new Size(248, 40);
            label2.TabIndex = 2;
            label2.Text = "Make a post";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(31, 247);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 256);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(31, 144);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 37);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 108);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 7;
            label1.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(175, 211);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(848, 93);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 9;
            label4.Text = "Picture";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(741, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Linen;
            button3.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(822, 440);
            button3.Name = "button3";
            button3.Size = new Size(167, 64);
            button3.TabIndex = 19;
            button3.Text = "Post";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 20;
            button1.Text = "Home Page";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddPost";
            Text = "AddPost";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button1;
    }
}