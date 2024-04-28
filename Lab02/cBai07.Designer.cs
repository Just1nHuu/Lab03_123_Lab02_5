namespace Lab02
{
    partial class cBai07
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            adasToolStripMenuItem = new ToolStripMenuItem();
            ádToolStripMenuItem = new ToolStripMenuItem();
            ádToolStripMenuItem1 = new ToolStripMenuItem();
            ádToolStripMenuItem2 = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            tThSinh = new TextBox();
            tNgSinh = new TextBox();
            label4 = new Label();
            tCung = new TextBox();
            button1 = new Button();
            label3 = new Label();
            contextMenuStrip3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { adasToolStripMenuItem, ádToolStripMenuItem1 });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(99, 48);
            // 
            // adasToolStripMenuItem
            // 
            adasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ádToolStripMenuItem });
            adasToolStripMenuItem.Name = "adasToolStripMenuItem";
            adasToolStripMenuItem.Size = new Size(98, 22);
            adasToolStripMenuItem.Text = "adas";
            // 
            // ádToolStripMenuItem
            // 
            ádToolStripMenuItem.Name = "ádToolStripMenuItem";
            ádToolStripMenuItem.Size = new Size(87, 22);
            ádToolStripMenuItem.Text = "ád";
            // 
            // ádToolStripMenuItem1
            // 
            ádToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ádToolStripMenuItem2 });
            ádToolStripMenuItem1.Name = "ádToolStripMenuItem1";
            ádToolStripMenuItem1.Size = new Size(98, 22);
            ádToolStripMenuItem1.Text = "ád";
            // 
            // ádToolStripMenuItem2
            // 
            ádToolStripMenuItem2.Name = "ádToolStripMenuItem2";
            ádToolStripMenuItem2.Size = new Size(87, 22);
            ádToolStripMenuItem2.Text = "ád";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(tThSinh, 1, 2);
            tableLayoutPanel1.Controls.Add(tNgSinh, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(tCung, 1, 3);
            tableLayoutPanel1.Controls.Add(button1, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.Size = new Size(351, 202);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 36);
            label2.TabIndex = 1;
            label2.Text = "Tháng sinh";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 37);
            label1.TabIndex = 0;
            label1.Text = "Ngày sinh";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tThSinh
            // 
            tThSinh.Dock = DockStyle.Fill;
            tThSinh.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tThSinh.Location = new Point(115, 117);
            tThSinh.Margin = new Padding(4);
            tThSinh.Name = "tThSinh";
            tThSinh.Size = new Size(121, 24);
            tThSinh.TabIndex = 3;
            // 
            // tNgSinh
            // 
            tNgSinh.Dock = DockStyle.Fill;
            tNgSinh.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tNgSinh.Location = new Point(115, 80);
            tNgSinh.Margin = new Padding(4);
            tNgSinh.Name = "tNgSinh";
            tNgSinh.Size = new Size(121, 24);
            tNgSinh.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 53);
            label4.TabIndex = 5;
            label4.Text = "Cung hoàng đạo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tCung
            // 
            tCung.Dock = DockStyle.Fill;
            tCung.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tCung.Location = new Point(115, 153);
            tCung.Margin = new Padding(4);
            tCung.Name = "tCung";
            tCung.Size = new Size(121, 24);
            tCung.TabIndex = 6;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(244, 153);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 7;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 3);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(343, 76);
            label3.TabIndex = 4;
            label3.Text = "Tìm cung hoàng đạo";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBai07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 202);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "cBai07";
            Text = "Bài tập 7";
            contextMenuStrip3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem adasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ádToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ádToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ádToolStripMenuItem2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNgSinh;
        private System.Windows.Forms.TextBox tThSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCung;
        private System.Windows.Forms.Button button1;
    }
}