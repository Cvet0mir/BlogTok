namespace BlogTok.Presentation
{
    partial class AdminHomePage
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
            button10 = new Button();
            button1 = new Button();
            button2 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 37);
            label2.Name = "label2";
            label2.Size = new Size(332, 40);
            label2.TabIndex = 24;
            label2.Text = "Admin Menu Page";
            // 
            // button10
            // 
            button10.BackColor = Color.Linen;
            button10.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(207, 217);
            button10.Name = "button10";
            button10.Size = new Size(167, 64);
            button10.TabIndex = 32;
            button10.Text = "Search Users";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(401, 217);
            button1.Name = "button1";
            button1.Size = new Size(167, 64);
            button1.TabIndex = 33;
            button1.Text = "Add Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(600, 217);
            button2.Name = "button2";
            button2.Size = new Size(167, 64);
            button2.TabIndex = 34;
            button2.Text = "All Posts";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(793, 217);
            button7.Name = "button7";
            button7.Size = new Size(167, 64);
            button7.TabIndex = 35;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button10);
            Controls.Add(label2);
            Name = "AdminHomePage";
            Text = "AdminHomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button10;
        private Button button1;
        private Button button2;
        private Button button7;
    }
}