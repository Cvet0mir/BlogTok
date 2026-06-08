namespace BlogTok.Presentation.PostForms
{
    partial class AddComment
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
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 18);
            label2.Name = "label2";
            label2.Size = new Size(311, 40);
            label2.TabIndex = 3;
            label2.Text = "Make a comment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(539, 96);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 10;
            label3.Text = "Content";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(368, 130);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 256);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 43);
            button2.TabIndex = 23;
            button2.Text = "Home Page";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Linen;
            button3.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(510, 430);
            button3.Name = "button3";
            button3.Size = new Size(167, 64);
            button3.TabIndex = 24;
            button3.Text = "Post";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AddComment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Name = "AddComment";
            Text = "AddComment";
            Load += AddComment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button3;
    }
}