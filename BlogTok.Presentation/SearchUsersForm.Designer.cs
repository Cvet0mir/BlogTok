namespace BlogTok.Presentation
{
    partial class SearchUsersForm
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 52);
            label2.Name = "label2";
            label2.Size = new Size(287, 33);
            label2.TabIndex = 3;
            label2.Text = "Search for Users";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 82);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(22, 157);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 26);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 137);
            label5.Name = "label5";
            label5.Size = new Size(215, 18);
            label5.TabIndex = 12;
            label5.Text = "Type the user's name...";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("SimSun", 10F);
            radioButton1.Location = new Point(6, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 18);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "All";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("SimSun", 10F);
            radioButton2.Location = new Point(6, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 18);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Following";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("SimSun", 10F);
            radioButton3.Location = new Point(69, 25);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(88, 18);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Followers";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("SimSun", 10F);
            radioButton4.Location = new Point(109, 49);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(116, 18);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Non-Following";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("SimSun", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 187);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(287, 22);
            button1.TabIndex = 14;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(439, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(544, 386);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // SearchUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1010, 390);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "SearchUsersForm";
            Text = "SearchUsersForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}