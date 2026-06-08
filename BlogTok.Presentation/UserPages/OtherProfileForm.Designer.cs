namespace BlogTok.Presentation
{
    partial class OtherProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherProfileForm));
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button5 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.Linen;
            button6.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(811, 300);
            button6.Name = "button6";
            button6.Size = new Size(167, 64);
            button6.TabIndex = 38;
            button6.Text = "Search Users";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Linen;
            button4.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(811, 205);
            button4.Name = "button4";
            button4.Size = new Size(167, 64);
            button4.TabIndex = 37;
            button4.Text = "Follow";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Linen;
            button3.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(811, 103);
            button3.Name = "button3";
            button3.Size = new Size(167, 64);
            button3.TabIndex = 36;
            button3.Text = "'s Posts";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("SimSun", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(467, 272);
            button2.Name = "button2";
            button2.Size = new Size(107, 107);
            button2.TabIndex = 35;
            button2.Text = "120";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("SimSun", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(467, 73);
            button1.Name = "button1";
            button1.Size = new Size(107, 107);
            button1.TabIndex = 34;
            button1.Text = "120";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 232);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 33;
            label1.Text = "Following";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(467, 34);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 32;
            label6.Text = "Followers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 399);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 449);
            label2.Name = "label2";
            label2.Size = new Size(0, 33);
            label2.TabIndex = 41;
            // 
            // button5
            // 
            button5.BackColor = Color.Coral;
            button5.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1013, -1);
            button5.Name = "button5";
            button5.Size = new Size(129, 43);
            button5.TabIndex = 42;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(1013, 476);
            button7.Name = "button7";
            button7.Size = new Size(129, 43);
            button7.TabIndex = 43;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // OtherProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OtherProfileForm";
            Text = "OtherProfileForm";
            Load += OtherProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button5;
        private Button button7;
    }
}