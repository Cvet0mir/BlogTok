namespace BlogTok.Presentation
{
    partial class EditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(784, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("SimSun", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(334, 300);
            button1.Name = "button1";
            button1.Size = new Size(394, 29);
            button1.TabIndex = 30;
            button1.Text = "Choose Picture...";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("SimSun", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(334, 258);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(394, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(334, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 30);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(334, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 30);
            textBox1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(93, 301);
            label7.Name = "label7";
            label7.Size = new Size(202, 23);
            label7.TabIndex = 24;
            label7.Text = "Profile Picture:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(93, 258);
            label8.Name = "label8";
            label8.Size = new Size(130, 23);
            label8.TabIndex = 23;
            label8.Text = "Birthdate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 217);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 22;
            label6.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 176);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 21;
            label5.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(473, 45);
            label2.Name = "label2";
            label2.Size = new Size(219, 33);
            label2.TabIndex = 18;
            label2.Text = "Edit Profile";
            // 
            // button3
            // 
            button3.BackColor = Color.Linen;
            button3.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(574, 427);
            button3.Name = "button3";
            button3.Size = new Size(167, 64);
            button3.TabIndex = 32;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(358, 427);
            button2.Name = "button2";
            button2.Size = new Size(167, 64);
            button2.TabIndex = 33;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "EditUserForm";
            Text = "EditUserForm";
            Load += EditUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label2;
        private Button button3;
        private Button button2;
    }
}