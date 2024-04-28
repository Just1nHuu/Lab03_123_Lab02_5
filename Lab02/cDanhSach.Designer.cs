namespace Lab02
{
    partial class cDanhSach
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
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(84, 105);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 0;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Bai01_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(264, 105);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(130, 54);
            button2.TabIndex = 0;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Bai02_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(451, 105);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(130, 54);
            button4.TabIndex = 0;
            button4.Text = "Bài 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Bai04_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(84, 202);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(130, 54);
            button5.TabIndex = 0;
            button5.Text = "Bài 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Bai05_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(264, 202);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(130, 54);
            button6.TabIndex = 0;
            button6.Text = "Bài 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Bai06_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(451, 202);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(130, 54);
            button7.TabIndex = 0;
            button7.Text = "Bài 7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Bai07_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(106, 22);
            label1.Name = "label1";
            label1.Size = new Size(475, 26);
            label1.TabIndex = 2;
            label1.Text = "Bài tập thực hành số 2 - Lập trình mạng căn bản";
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Blue;
            button10.Location = new Point(70, 289);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(536, 54);
            button10.TabIndex = 3;
            button10.Text = "Thoát";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // cDanhSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 380);
            Controls.Add(button10);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "cDanhSach";
            Text = "Danh sách chức năng ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
    }
}

