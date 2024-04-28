namespace Lab02
{
    partial class cBai01
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
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            FilePath = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12.75F);
            button1.Location = new Point(42, 58);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 0;
            button1.Text = "Đọc file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12.75F);
            button2.Location = new Point(42, 104);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 1;
            button2.Text = "Ghi file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Microsoft Sans Serif", 12.75F);
            richTextBox1.Location = new Point(208, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(195, 141);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12.75F);
            button3.Location = new Point(42, 150);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 3;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FilePath
            // 
            FilePath.Font = new Font("Microsoft Sans Serif", 12.75F);
            FilePath.Location = new Point(42, 13);
            FilePath.Margin = new Padding(4);
            FilePath.Name = "FilePath";
            FilePath.Size = new Size(361, 27);
            FilePath.TabIndex = 6;
            // 
            // cBai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 210);
            Controls.Add(FilePath);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "cBai01";
            Text = "Bài tập 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button button3;
        private TextBox FilePath;
    }
}