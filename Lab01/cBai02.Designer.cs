namespace Lab01
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
            this.components = new System.ComponentModel.Container();
            this.TieuDeMot = new System.Windows.Forms.Label();
            this.TieuDeHai = new System.Windows.Forms.Label();
            this.TieuDeBa = new System.Windows.Forms.Label();
            this.TinhSoBe = new System.Windows.Forms.Label();
            this.bXoa = new System.Windows.Forms.Button();
            this.bTim = new System.Windows.Forms.Button();
            this.bThoat = new System.Windows.Forms.Button();
            this.SoLon = new System.Windows.Forms.TextBox();
            this.SoBe = new System.Windows.Forms.TextBox();
            this.TinhSoLon = new System.Windows.Forms.Label();
            this.SoMot = new System.Windows.Forms.TextBox();
            this.SoHai = new System.Windows.Forms.TextBox();
            this.SoBa = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TieuDeMot
            // 
            this.TieuDeMot.AutoSize = true;
            this.TieuDeMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDeMot.Location = new System.Drawing.Point(80, 111);
            this.TieuDeMot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieuDeMot.Name = "TieuDeMot";
            this.TieuDeMot.Size = new System.Drawing.Size(112, 25);
            this.TieuDeMot.TabIndex = 0;
            this.TieuDeMot.Text = "Số thứ nhất";
            this.TieuDeMot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TieuDeHai
            // 
            this.TieuDeHai.AutoSize = true;
            this.TieuDeHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDeHai.Location = new System.Drawing.Point(284, 111);
            this.TieuDeHai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieuDeHai.Name = "TieuDeHai";
            this.TieuDeHai.Size = new System.Drawing.Size(100, 25);
            this.TieuDeHai.TabIndex = 1;
            this.TieuDeHai.Text = "Số thứ hai";
            // 
            // TieuDeBa
            // 
            this.TieuDeBa.AutoSize = true;
            this.TieuDeBa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDeBa.Location = new System.Drawing.Point(480, 111);
            this.TieuDeBa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieuDeBa.Name = "TieuDeBa";
            this.TieuDeBa.Size = new System.Drawing.Size(96, 25);
            this.TieuDeBa.TabIndex = 1;
            this.TieuDeBa.Text = "Số thứ ba";
            // 
            // TinhSoBe
            // 
            this.TinhSoBe.AutoSize = true;
            this.TinhSoBe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhSoBe.Location = new System.Drawing.Point(365, 266);
            this.TinhSoBe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TinhSoBe.Name = "TinhSoBe";
            this.TinhSoBe.Size = new System.Drawing.Size(112, 25);
            this.TinhSoBe.TabIndex = 2;
            this.TinhSoBe.Text = "Số bé nhất ";
            // 
            // bXoa
            // 
            this.bXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXoa.Location = new System.Drawing.Point(284, 192);
            this.bXoa.Margin = new System.Windows.Forms.Padding(4);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(100, 39);
            this.bXoa.TabIndex = 3;
            this.bXoa.Text = "Xoá ";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.click_Xoa);
            // 
            // bTim
            // 
            this.bTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTim.Location = new System.Drawing.Point(84, 192);
            this.bTim.Margin = new System.Windows.Forms.Padding(4);
            this.bTim.Name = "bTim";
            this.bTim.Size = new System.Drawing.Size(100, 39);
            this.bTim.TabIndex = 3;
            this.bTim.Text = "Tìm";
            this.bTim.UseVisualStyleBackColor = true;
            this.bTim.Click += new System.EventHandler(this.click_Tim);
            // 
            // bThoat
            // 
            this.bThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThoat.Location = new System.Drawing.Point(485, 192);
            this.bThoat.Margin = new System.Windows.Forms.Padding(4);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(100, 39);
            this.bThoat.TabIndex = 3;
            this.bThoat.Text = "Thoát";
            this.bThoat.UseVisualStyleBackColor = true;
            this.bThoat.Click += new System.EventHandler(this.click_Thoat);
            // 
            // SoLon
            // 
            this.SoLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLon.Location = new System.Drawing.Point(199, 266);
            this.SoLon.Margin = new System.Windows.Forms.Padding(4);
            this.SoLon.Name = "SoLon";
            this.SoLon.Size = new System.Drawing.Size(132, 30);
            this.SoLon.TabIndex = 4;
            // 
            // SoBe
            // 
            this.SoBe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoBe.Location = new System.Drawing.Point(485, 266);
            this.SoBe.Margin = new System.Windows.Forms.Padding(4);
            this.SoBe.Name = "SoBe";
            this.SoBe.Size = new System.Drawing.Size(132, 30);
            this.SoBe.TabIndex = 4;
            // 
            // TinhSoLon
            // 
            this.TinhSoLon.AutoSize = true;
            this.TinhSoLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhSoLon.Location = new System.Drawing.Point(80, 266);
            this.TinhSoLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TinhSoLon.Name = "TinhSoLon";
            this.TinhSoLon.Size = new System.Drawing.Size(111, 25);
            this.TinhSoLon.TabIndex = 2;
            this.TinhSoLon.Text = "Số lớn nhất";
            // 
            // SoMot
            // 
            this.SoMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoMot.Location = new System.Drawing.Point(86, 148);
            this.SoMot.Margin = new System.Windows.Forms.Padding(4);
            this.SoMot.Name = "SoMot";
            this.SoMot.Size = new System.Drawing.Size(132, 30);
            this.SoMot.TabIndex = 5;
            // 
            // SoHai
            // 
            this.SoHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHai.Location = new System.Drawing.Point(284, 148);
            this.SoHai.Margin = new System.Windows.Forms.Padding(4);
            this.SoHai.Name = "SoHai";
            this.SoHai.Size = new System.Drawing.Size(132, 30);
            this.SoHai.TabIndex = 5;
            // 
            // SoBa
            // 
            this.SoBa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoBa.Location = new System.Drawing.Point(485, 148);
            this.SoBa.Margin = new System.Windows.Forms.Padding(4);
            this.SoBa.Name = "SoBa";
            this.SoBa.Size = new System.Drawing.Size(132, 30);
            this.SoBa.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(91, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm số nhỏ nhất và lớn nhất trong 3 số";
            // 
            // cBai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoBa);
            this.Controls.Add(this.SoHai);
            this.Controls.Add(this.SoMot);
            this.Controls.Add(this.SoBe);
            this.Controls.Add(this.SoLon);
            this.Controls.Add(this.bThoat);
            this.Controls.Add(this.bTim);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.TinhSoBe);
            this.Controls.Add(this.TinhSoLon);
            this.Controls.Add(this.TieuDeBa);
            this.Controls.Add(this.TieuDeHai);
            this.Controls.Add(this.TieuDeMot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cBai02";
            this.Text = "Bài tập 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TieuDeMot;
        private System.Windows.Forms.Label TieuDeHai;
        private System.Windows.Forms.Label TieuDeBa;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button bTim;
        private System.Windows.Forms.Button bThoat;
        private System.Windows.Forms.TextBox SoLon;
        private System.Windows.Forms.TextBox SoBe;
        private System.Windows.Forms.Label TinhSoLon;
        private System.Windows.Forms.Label TinhSoBe;
        private System.Windows.Forms.TextBox SoMot;
        private System.Windows.Forms.TextBox SoHai;
        private System.Windows.Forms.TextBox SoBa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}