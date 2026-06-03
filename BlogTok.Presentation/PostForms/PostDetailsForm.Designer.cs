namespace BlogTok.Presentation
{
    partial class PostDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostDetailsForm));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button5 = new Button();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 353);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 386);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 20;
            label2.Text = "Title";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(395, 13);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(377, 428);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(793, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(574, 480);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1277, -2);
            button2.Name = "button2";
            button2.Size = new Size(100, 33);
            button2.TabIndex = 26;
            button2.Text = "Home Page";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("SimSun", 10F);
            button4.Location = new Point(290, 453);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 31;
            button4.Text = "👎";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Font = new Font("SimSun", 10F);
            button3.Location = new Point(512, 453);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 30;
            button3.Text = "😂";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("SimSun", 10F);
            button1.Location = new Point(717, 453);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 29;
            button1.Text = "😭";
            button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGreen;
            button5.Font = new Font("SimSun", 10F);
            button5.Location = new Point(96, 453);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 28;
            button5.Text = "👍";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 461);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 32;
            label5.Text = "0";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 461);
            label1.Name = "label1";
            label1.Size = new Size(22, 23);
            label1.TabIndex = 33;
            label1.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(431, 461);
            label3.Name = "label3";
            label3.Size = new Size(22, 23);
            label3.TabIndex = 34;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(639, 461);
            label4.Name = "label4";
            label4.Size = new Size(22, 23);
            label4.TabIndex = 35;
            label4.Text = "0";
            // 
            // PostDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1379, 501);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "PostDetailsForm";
            Text = "PostDetailsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button5;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}