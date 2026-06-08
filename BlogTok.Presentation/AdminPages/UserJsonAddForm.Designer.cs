namespace BlogTok.Presentation
{
    partial class UserJsonAddForm
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
            label2 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 1);
            button2.Name = "button2";
            button2.Size = new Size(129, 43);
            button2.TabIndex = 22;
            button2.Text = "Home Page";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(416, 82);
            label2.Name = "label2";
            label2.Size = new Size(353, 40);
            label2.TabIndex = 23;
            label2.Text = "Search for Users";
            // 
            // button6
            // 
            button6.BackColor = Color.Linen;
            button6.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(502, 225);
            button6.Name = "button6";
            button6.Size = new Size(203, 103);
            button6.TabIndex = 39;
            button6.Text = "Add Users with JSON";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // UserJsonAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1154, 520);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(button2);
            Name = "UserJsonAddForm";
            Text = "UserJsonAddForm";
            Load += UserJsonAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private Button button6;
    }
}