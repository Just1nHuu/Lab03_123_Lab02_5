using System.Runtime.CompilerServices;

namespace Lab01
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
            this.clink_Tinh = new System.Windows.Forms.Button();
            this.tMot = new System.Windows.Forms.TextBox();
            this.tHai = new System.Windows.Forms.TextBox();
            this.tTong = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clink_Tinh
            // 
            this.clink_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clink_Tinh.Location = new System.Drawing.Point(79, 235);
            this.clink_Tinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clink_Tinh.Name = "clink_Tinh";
            this.clink_Tinh.Size = new System.Drawing.Size(100, 28);
            this.clink_Tinh.TabIndex = 0;
            this.clink_Tinh.Text = "Tính ";
            this.clink_Tinh.UseVisualStyleBackColor = true;
            this.clink_Tinh.Click += new System.EventHandler(this.button_Tinh);
            // 
            // tMot
            // 
            this.tMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMot.Location = new System.Drawing.Point(339, 115);
            this.tMot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tMot.Name = "tMot";
            this.tMot.Size = new System.Drawing.Size(132, 30);
            this.tMot.TabIndex = 1;
            this.tMot.TextChanged += new System.EventHandler(this.text_SoThuNhat);
            // 
            // tHai
            // 
            this.tHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHai.Location = new System.Drawing.Point(339, 172);
            this.tHai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tHai.Name = "tHai";
            this.tHai.Size = new System.Drawing.Size(132, 30);
            this.tHai.TabIndex = 1;
            this.tHai.TextChanged += new System.EventHandler(this.text_SoThuHai);
            // 
            // tTong
            // 
            this.tTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTong.Location = new System.Drawing.Point(339, 235);
            this.tTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tTong.Name = "tTong";
            this.tTong.Size = new System.Drawing.Size(132, 30);
            this.tTong.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(79, 115);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 30);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Số thứ nhất";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(79, 172);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 30);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "Số thứ hai";
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSize = true;
            this.TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDe.ForeColor = System.Drawing.Color.Red;
            this.TieuDe.Location = new System.Drawing.Point(91, 36);
            this.TieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(364, 32);
            this.TieuDe.TabIndex = 3;
            this.TieuDe.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            this.TieuDe.Click += new System.EventHandler(this.TieuDe_Click);
            // 
            // cBai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 316);
            this.Controls.Add(this.TieuDe);
            this.Controls.Add(this.tTong);
            this.Controls.Add(this.tHai);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tMot);
            this.Controls.Add(this.clink_Tinh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cBai01";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clink_Tinh;
        private System.Windows.Forms.TextBox tMot;
        private System.Windows.Forms.TextBox tHai;
        private System.Windows.Forms.TextBox tTong;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label TieuDe;

       
    }
}