namespace Lab01
{
    partial class cBai03
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
            this.label_So = new System.Windows.Forms.Label();
            this.So = new System.Windows.Forms.TextBox();
            this.Doc = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_So
            // 
            this.label_So.AutoSize = true;
            this.label_So.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_So.Location = new System.Drawing.Point(31, 140);
            this.label_So.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_So.Name = "label_So";
            this.label_So.Size = new System.Drawing.Size(246, 25);
            this.label_So.TabIndex = 0;
            this.label_So.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // So
            // 
            this.So.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So.Location = new System.Drawing.Point(339, 130);
            this.So.Margin = new System.Windows.Forms.Padding(4);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(132, 30);
            this.So.TabIndex = 1;
            // 
            // Doc
            // 
            this.Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.Location = new System.Drawing.Point(507, 130);
            this.Doc.Margin = new System.Windows.Forms.Padding(4);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(100, 45);
            this.Doc.TabIndex = 3;
            this.Doc.Text = "Đọc";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.TextChanged += new System.EventHandler(this.click_Doc);
            this.Doc.Click += new System.EventHandler(this.click_Doc);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(507, 183);
            this.Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(100, 46);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xoá ";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.click_Xoa);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(507, 237);
            this.Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(100, 39);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.click_Thoat);
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KetQua.Location = new System.Drawing.Point(197, 242);
            this.label_KetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(80, 25);
            this.label_KetQua.TabIndex = 0;
            this.label_KetQua.Text = "Kết quả";
            // 
            // KetQua
            // 
            this.KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(339, 235);
            this.KetQua.Margin = new System.Windows.Forms.Padding(4);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(132, 30);
            this.KetQua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(279, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đọc chữ số";
            // 
            // cBai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.So);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.label_So);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cBai03";
            this.Text = "Bài tập 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_So;
        private System.Windows.Forms.TextBox So;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label label_KetQua;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.Label label1;
    }
}