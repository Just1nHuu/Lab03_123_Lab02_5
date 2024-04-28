namespace Lab02
{
    partial class cBai02
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
            btnread = new Button();
            txtfile = new RichTextBox();
            btnexit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtfilename = new TextBox();
            txtsize = new TextBox();
            txturl = new TextBox();
            txtline = new TextBox();
            txtword = new TextBox();
            txtcharacter = new TextBox();
            SuspendLayout();
            // 
            // btnread
            // 
            btnread.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnread.Location = new Point(6, 12);
            btnread.Name = "btnread";
            btnread.Size = new Size(446, 35);
            btnread.TabIndex = 0;
            btnread.Text = "Đọc thông tin từ file";
            btnread.UseVisualStyleBackColor = true;
            btnread.Click += btnread_Click_1;
            // 
            // txtfile
            // 
            txtfile.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtfile.Location = new Point(464, 10);
            txtfile.Name = "txtfile";
            txtfile.Size = new Size(195, 364);
            txtfile.TabIndex = 1;
            txtfile.Text = " ";
            // 
            // btnexit
            // 
            btnexit.AutoSize = true;
            btnexit.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnexit.Location = new Point(12, 391);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(440, 39);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.75F);
            label1.Location = new Point(2, 84);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.75F);
            label2.Location = new Point(2, 130);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "kích thước";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12.75F);
            label3.Location = new Point(2, 182);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12.75F);
            label4.Location = new Point(2, 244);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 2;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12.75F);
            label5.Location = new Point(3, 298);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 2;
            label5.Text = "Words count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12.75F);
            label6.Location = new Point(2, 347);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 2;
            label6.Text = "Character count";
            // 
            // txtfilename
            // 
            txtfilename.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtfilename.Location = new Point(133, 74);
            txtfilename.Multiline = true;
            txtfilename.Name = "txtfilename";
            txtfilename.Size = new Size(319, 38);
            txtfilename.TabIndex = 3;
            txtfilename.TextAlign = HorizontalAlignment.Center;
            // 
            // txtsize
            // 
            txtsize.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtsize.Location = new Point(133, 120);
            txtsize.Multiline = true;
            txtsize.Name = "txtsize";
            txtsize.Size = new Size(319, 38);
            txtsize.TabIndex = 3;
            txtsize.TextAlign = HorizontalAlignment.Center;
            // 
            // txturl
            // 
            txturl.Font = new Font("Microsoft Sans Serif", 12.75F);
            txturl.Location = new Point(133, 165);
            txturl.Multiline = true;
            txturl.Name = "txturl";
            txturl.Size = new Size(319, 57);
            txturl.TabIndex = 3;
            txturl.TextAlign = HorizontalAlignment.Center;
            // 
            // txtline
            // 
            txtline.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtline.Location = new Point(133, 228);
            txtline.Multiline = true;
            txtline.Name = "txtline";
            txtline.Size = new Size(319, 38);
            txtline.TabIndex = 3;
            txtline.TextAlign = HorizontalAlignment.Center;
            // 
            // txtword
            // 
            txtword.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtword.Location = new Point(133, 281);
            txtword.Multiline = true;
            txtword.Name = "txtword";
            txtword.Size = new Size(319, 38);
            txtword.TabIndex = 3;
            txtword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtcharacter
            // 
            txtcharacter.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtcharacter.Location = new Point(133, 336);
            txtcharacter.Multiline = true;
            txtcharacter.Name = "txtcharacter";
            txtcharacter.Size = new Size(319, 38);
            txtcharacter.TabIndex = 3;
            txtcharacter.TextAlign = HorizontalAlignment.Center;
            // 
            // cBai02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 449);
            Controls.Add(txtcharacter);
            Controls.Add(txtword);
            Controls.Add(txtline);
            Controls.Add(txturl);
            Controls.Add(txtsize);
            Controls.Add(txtfilename);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtfile);
            Controls.Add(btnexit);
            Controls.Add(btnread);
            Name = "cBai02";
            Text = "Bài tập 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.RichTextBox txtfile;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TextBox txtline;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.TextBox txtcharacter;
    }
}

