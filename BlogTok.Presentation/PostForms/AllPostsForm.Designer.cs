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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 43);
            button2.TabIndex = 25;
            button2.Text = "Home Page";
            button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
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
            label2.Location = new Point(121, 87);
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
            groupBox1.Location = new Point(21, 213);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(328, 84);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter By";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("SimSun", 10F);
            radioButton3.Location = new Point(99, 34);
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
            radioButton1.Location = new Point(7, 34);
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
            button1.Location = new Point(21, 313);
            button1.Name = "button1";
            button1.Size = new Size(328, 29);
            button1.TabIndex = 27;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // AllPostsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Name = "AllPostsForm";
            Text = "AllPostsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}