namespace Lab02
{
    partial class cBai04
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
            txtFileContent = new RichTextBox();
            btnWrite = new Button();
            btnRead = new Button();
            lbWriteName = new Label();
            lbWriteID = new Label();
            lbWriteCourse1 = new Label();
            lbWritePhone = new Label();
            lbWriteCourse2 = new Label();
            lbWriteCourse3 = new Label();
            lbReadName = new Label();
            btnAdd = new Button();
            txtWriteName = new TextBox();
            txtWriteCourse3 = new TextBox();
            txtReadID = new TextBox();
            txtReadName = new TextBox();
            txtWriteID = new TextBox();
            txtWritePhone = new TextBox();
            txtWriteCourse1 = new TextBox();
            txtWriteCourse2 = new TextBox();
            txtReadCourse3 = new TextBox();
            txtReadCourse2 = new TextBox();
            txtReadCourse1 = new TextBox();
            txtReadPhone = new TextBox();
            lbReadCourse3 = new Label();
            lbReadCourse2 = new Label();
            lbReadCourse1 = new Label();
            lbReadPhone = new Label();
            lbReadID = new Label();
            lbAverage = new Label();
            txtAverage = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            lbPageNumber = new Label();
            SuspendLayout();
            // 
            // txtFileContent
            // 
            txtFileContent.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtFileContent.Location = new Point(395, 9);
            txtFileContent.Margin = new Padding(3, 2, 3, 2);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(405, 501);
            txtFileContent.TabIndex = 0;
            txtFileContent.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.AutoSize = true;
            btnWrite.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnWrite.Location = new Point(10, 20);
            btnWrite.Margin = new Padding(3, 2, 3, 2);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(364, 58);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write to an output file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.AutoSize = true;
            btnRead.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnRead.Location = new Point(802, 20);
            btnRead.Margin = new Padding(3, 2, 3, 2);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(382, 58);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read from an input file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lbWriteName
            // 
            lbWriteName.AutoSize = true;
            lbWriteName.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbWriteName.Location = new Point(290, 101);
            lbWriteName.Name = "lbWriteName";
            lbWriteName.Size = new Size(53, 20);
            lbWriteName.TabIndex = 3;
            lbWriteName.Text = "Name";
            // 
            // lbWriteID
            // 
            lbWriteID.AutoSize = true;
            lbWriteID.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbWriteID.Location = new Point(290, 161);
            lbWriteID.Name = "lbWriteID";
            lbWriteID.Size = new Size(26, 20);
            lbWriteID.TabIndex = 4;
            lbWriteID.Text = "ID";
            // 
            // lbWriteCourse1
            // 
            lbWriteCourse1.AutoSize = true;
            lbWriteCourse1.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbWriteCourse1.Location = new Point(290, 274);
            lbWriteCourse1.Name = "lbWriteCourse1";
            lbWriteCourse1.Size = new Size(77, 20);
            lbWriteCourse1.TabIndex = 6;
            lbWriteCourse1.Text = "Course 1";
            // 
            // lbWritePhone
            // 
            lbWritePhone.AutoSize = true;
            lbWritePhone.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbWritePhone.Location = new Point(290, 220);
            lbWritePhone.Name = "lbWritePhone";
            lbWritePhone.Size = new Size(56, 20);
            lbWritePhone.TabIndex = 5;
            lbWritePhone.Text = "Phone";
            // 
            // lbWriteCourse2
            // 
            lbWriteCourse2.AutoSize = true;
            lbWriteCourse2.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbWriteCourse2.Location = new Point(290, 328);
            lbWriteCourse2.Name = "lbWriteCourse2";
            lbWriteCourse2.Size = new Size(77, 20);
            lbWriteCourse2.TabIndex = 7;
            lbWriteCourse2.Text = "Course 2";
            // 
            // lbWriteCourse3
            // 
            lbWriteCourse3.AutoSize = true;
            lbWriteCourse3.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbWriteCourse3.Location = new Point(290, 384);
            lbWriteCourse3.Name = "lbWriteCourse3";
            lbWriteCourse3.Size = new Size(77, 20);
            lbWriteCourse3.TabIndex = 8;
            lbWriteCourse3.Text = "Course 3";
            // 
            // lbReadName
            // 
            lbReadName.AutoSize = true;
            lbReadName.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbReadName.Location = new Point(1091, 105);
            lbReadName.Name = "lbReadName";
            lbReadName.Size = new Size(53, 20);
            lbReadName.TabIndex = 9;
            lbReadName.Text = "Name";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnAdd.Location = new Point(10, 472);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 38);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add to list";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtWriteName
            // 
            txtWriteName.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtWriteName.Location = new Point(10, 98);
            txtWriteName.Margin = new Padding(3, 2, 3, 2);
            txtWriteName.Name = "txtWriteName";
            txtWriteName.Size = new Size(248, 27);
            txtWriteName.TabIndex = 11;
            // 
            // txtWriteCourse3
            // 
            txtWriteCourse3.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtWriteCourse3.Location = new Point(10, 377);
            txtWriteCourse3.Margin = new Padding(3, 2, 3, 2);
            txtWriteCourse3.Name = "txtWriteCourse3";
            txtWriteCourse3.Size = new Size(248, 27);
            txtWriteCourse3.TabIndex = 12;
            // 
            // txtReadID
            // 
            txtReadID.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtReadID.Location = new Point(806, 161);
            txtReadID.Margin = new Padding(3, 2, 3, 2);
            txtReadID.Name = "txtReadID";
            txtReadID.Size = new Size(248, 27);
            txtReadID.TabIndex = 13;
            // 
            // txtReadName
            // 
            txtReadName.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtReadName.Location = new Point(806, 102);
            txtReadName.Margin = new Padding(3, 2, 3, 2);
            txtReadName.Name = "txtReadName";
            txtReadName.Size = new Size(248, 27);
            txtReadName.TabIndex = 14;
            // 
            // txtWriteID
            // 
            txtWriteID.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtWriteID.Location = new Point(10, 154);
            txtWriteID.Margin = new Padding(3, 2, 3, 2);
            txtWriteID.Name = "txtWriteID";
            txtWriteID.Size = new Size(248, 27);
            txtWriteID.TabIndex = 15;
            // 
            // txtWritePhone
            // 
            txtWritePhone.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtWritePhone.Location = new Point(10, 213);
            txtWritePhone.Margin = new Padding(3, 2, 3, 2);
            txtWritePhone.Name = "txtWritePhone";
            txtWritePhone.Size = new Size(248, 27);
            txtWritePhone.TabIndex = 16;
            // 
            // txtWriteCourse1
            // 
            txtWriteCourse1.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtWriteCourse1.Location = new Point(10, 267);
            txtWriteCourse1.Margin = new Padding(3, 2, 3, 2);
            txtWriteCourse1.Name = "txtWriteCourse1";
            txtWriteCourse1.Size = new Size(248, 27);
            txtWriteCourse1.TabIndex = 17;
            // 
            // txtWriteCourse2
            // 
            txtWriteCourse2.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtWriteCourse2.Location = new Point(10, 321);
            txtWriteCourse2.Margin = new Padding(3, 2, 3, 2);
            txtWriteCourse2.Name = "txtWriteCourse2";
            txtWriteCourse2.Size = new Size(248, 27);
            txtWriteCourse2.TabIndex = 18;
            // 
            // txtReadCourse3
            // 
            txtReadCourse3.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtReadCourse3.Location = new Point(806, 377);
            txtReadCourse3.Margin = new Padding(3, 2, 3, 2);
            txtReadCourse3.Name = "txtReadCourse3";
            txtReadCourse3.Size = new Size(248, 27);
            txtReadCourse3.TabIndex = 19;
            // 
            // txtReadCourse2
            // 
            txtReadCourse2.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtReadCourse2.Location = new Point(806, 325);
            txtReadCourse2.Margin = new Padding(3, 2, 3, 2);
            txtReadCourse2.Name = "txtReadCourse2";
            txtReadCourse2.Size = new Size(248, 27);
            txtReadCourse2.TabIndex = 20;
            // 
            // txtReadCourse1
            // 
            txtReadCourse1.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtReadCourse1.Location = new Point(806, 274);
            txtReadCourse1.Margin = new Padding(3, 2, 3, 2);
            txtReadCourse1.Name = "txtReadCourse1";
            txtReadCourse1.Size = new Size(248, 27);
            txtReadCourse1.TabIndex = 21;
            // 
            // txtReadPhone
            // 
            txtReadPhone.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtReadPhone.Location = new Point(806, 220);
            txtReadPhone.Margin = new Padding(3, 2, 3, 2);
            txtReadPhone.Name = "txtReadPhone";
            txtReadPhone.Size = new Size(248, 27);
            txtReadPhone.TabIndex = 22;
            // 
            // lbReadCourse3
            // 
            lbReadCourse3.AutoSize = true;
            lbReadCourse3.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbReadCourse3.Location = new Point(1091, 380);
            lbReadCourse3.Name = "lbReadCourse3";
            lbReadCourse3.Size = new Size(77, 20);
            lbReadCourse3.TabIndex = 27;
            lbReadCourse3.Text = "Course 3";
            // 
            // lbReadCourse2
            // 
            lbReadCourse2.AutoSize = true;
            lbReadCourse2.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbReadCourse2.Location = new Point(1091, 321);
            lbReadCourse2.Name = "lbReadCourse2";
            lbReadCourse2.Size = new Size(77, 20);
            lbReadCourse2.TabIndex = 26;
            lbReadCourse2.Text = "Course 2";
            // 
            // lbReadCourse1
            // 
            lbReadCourse1.AutoSize = true;
            lbReadCourse1.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbReadCourse1.Location = new Point(1091, 277);
            lbReadCourse1.Name = "lbReadCourse1";
            lbReadCourse1.Size = new Size(77, 20);
            lbReadCourse1.TabIndex = 25;
            lbReadCourse1.Text = "Course 1";
            // 
            // lbReadPhone
            // 
            lbReadPhone.AutoSize = true;
            lbReadPhone.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbReadPhone.Location = new Point(1091, 227);
            lbReadPhone.Name = "lbReadPhone";
            lbReadPhone.Size = new Size(56, 20);
            lbReadPhone.TabIndex = 24;
            lbReadPhone.Text = "Phone";
            // 
            // lbReadID
            // 
            lbReadID.AutoSize = true;
            lbReadID.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbReadID.Location = new Point(1091, 168);
            lbReadID.Name = "lbReadID";
            lbReadID.Size = new Size(26, 20);
            lbReadID.TabIndex = 23;
            lbReadID.Text = "ID";
            // 
            // lbAverage
            // 
            lbAverage.AutoSize = true;
            lbAverage.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbAverage.Location = new Point(1091, 436);
            lbAverage.Name = "lbAverage";
            lbAverage.Size = new Size(70, 20);
            lbAverage.TabIndex = 28;
            lbAverage.Text = "Average";
            // 
            // txtAverage
            // 
            txtAverage.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtAverage.Location = new Point(806, 429);
            txtAverage.Margin = new Padding(3, 2, 3, 2);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(248, 27);
            txtAverage.TabIndex = 29;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnBack.Location = new Point(806, 472);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 38);
            btnBack.TabIndex = 30;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.AutoSize = true;
            btnNext.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnNext.Location = new Point(1071, 472);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 38);
            btnNext.TabIndex = 31;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lbPageNumber
            // 
            lbPageNumber.AutoSize = true;
            lbPageNumber.Font = new Font("Microsoft Sans Serif", 12.75F);
            lbPageNumber.Location = new Point(978, 490);
            lbPageNumber.Name = "lbPageNumber";
            lbPageNumber.Size = new Size(18, 20);
            lbPageNumber.TabIndex = 32;
            lbPageNumber.Text = "0";
            // 
            // cBai04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 527);
            Controls.Add(lbPageNumber);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txtAverage);
            Controls.Add(lbAverage);
            Controls.Add(lbReadCourse3);
            Controls.Add(lbReadCourse2);
            Controls.Add(lbReadCourse1);
            Controls.Add(lbReadPhone);
            Controls.Add(lbReadID);
            Controls.Add(txtReadPhone);
            Controls.Add(txtReadCourse1);
            Controls.Add(txtReadCourse2);
            Controls.Add(txtReadCourse3);
            Controls.Add(txtWriteCourse2);
            Controls.Add(txtWriteCourse1);
            Controls.Add(txtWritePhone);
            Controls.Add(txtWriteID);
            Controls.Add(txtReadName);
            Controls.Add(txtReadID);
            Controls.Add(txtWriteCourse3);
            Controls.Add(txtWriteName);
            Controls.Add(btnAdd);
            Controls.Add(lbReadName);
            Controls.Add(lbWriteCourse3);
            Controls.Add(lbWriteCourse2);
            Controls.Add(lbWriteCourse1);
            Controls.Add(lbWritePhone);
            Controls.Add(lbWriteID);
            Controls.Add(lbWriteName);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(txtFileContent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "cBai04";
            Text = "Bài tập 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lbWriteName;
        private System.Windows.Forms.Label lbWriteID;
        private System.Windows.Forms.Label lbWriteCourse1;
        private System.Windows.Forms.Label lbWritePhone;
        private System.Windows.Forms.Label lbWriteCourse2;
        private System.Windows.Forms.Label lbWriteCourse3;
        private System.Windows.Forms.Label lbReadName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtWriteName;
        private System.Windows.Forms.TextBox txtWriteCourse3;
        private System.Windows.Forms.TextBox txtReadID;
        private System.Windows.Forms.TextBox txtReadName;
        private System.Windows.Forms.TextBox txtWriteID;
        private System.Windows.Forms.TextBox txtWritePhone;
        private System.Windows.Forms.TextBox txtWriteCourse1;
        private System.Windows.Forms.TextBox txtWriteCourse2;
        private System.Windows.Forms.TextBox txtReadCourse3;
        private System.Windows.Forms.TextBox txtReadCourse2;
        private System.Windows.Forms.TextBox txtReadCourse1;
        private System.Windows.Forms.TextBox txtReadPhone;
        private System.Windows.Forms.Label lbReadCourse3;
        private System.Windows.Forms.Label lbReadCourse2;
        private System.Windows.Forms.Label lbReadCourse1;
        private System.Windows.Forms.Label lbReadPhone;
        private System.Windows.Forms.Label lbReadID;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbPageNumber;
    }
}