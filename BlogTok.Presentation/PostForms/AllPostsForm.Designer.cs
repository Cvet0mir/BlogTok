namespace BlogTok.Presentation.PostForms
{
    partial class AllPostsForm
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
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(11, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 43);
            button2.TabIndex = 25;
            button2.Text = "Home Page";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(498, 3);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(622, 515);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 85);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 22;
            label2.Text = "Posts";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 329);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(328, 76);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sort By";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("SimSun", 10F);
            radioButton3.Location = new Point(99, 35);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(119, 21);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Most Liked";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("SimSun", 10F);
            radioButton1.Location = new Point(7, 35);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Date";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("SimSun", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 271);
            button1.Name = "button1";
            button1.Size = new Size(327, 29);
            button1.TabIndex = 27;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 208);
            label5.Name = "label5";
            label5.Size = new Size(262, 23);
            label5.TabIndex = 29;
            label5.Text = "Type a user's name...";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(21, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(327, 30);
            textBox3.TabIndex = 28;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 413);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(328, 103);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter By";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("SimSun", 10F);
            radioButton2.Location = new Point(184, 65);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 21);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "All";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("SimSun", 10F);
            radioButton6.Location = new Point(7, 65);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(164, 21);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "Commented Posts";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("SimSun", 10F);
            radioButton7.Location = new Point(139, 33);
            radioButton7.Margin = new Padding(3, 4, 3, 4);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(128, 21);
            radioButton7.TabIndex = 4;
            radioButton7.TabStop = true;
            radioButton7.Text = "Liked Posts";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("SimSun", 10F);
            radioButton8.Location = new Point(7, 33);
            radioButton8.Margin = new Padding(3, 4, 3, 4);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(119, 21);
            radioButton8.TabIndex = 3;
            radioButton8.TabStop = true;
            radioButton8.Text = "Your Posts";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // AllPostsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Name = "AllPostsForm";
            Text = "AllPostsForm";
            Load += AllPostsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private Button button1;
        private Label label5;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton2;
    }
}