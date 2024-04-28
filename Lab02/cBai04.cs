using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class cBai04 : Form
    {
        public cBai04()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        List<int> pagenumbers = new List<int>();

        private void btnRead_Click(object sender, EventArgs e)
        {
            Serialized();
            Deserialized();
            Setup();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fsout = new FileStream("output4.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fsout);
            writer.Write(txtFileContent.Text);
            writer.Close();
            fsout.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentpagenumber = Convert.ToInt32(lbPageNumber.Text);
            if (currentpagenumber < students.Count ) //If not in the last student
            {
                ShowObject(currentpagenumber ); //Go to next student
            }
            // If in the last student, do nothing
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int currentpagenumber = Convert.ToInt32(lbPageNumber.Text);
            if (currentpagenumber > 1) //If not in the first object
            {
                ShowObject(currentpagenumber - 2); //Back to previous object
            }
            // If in the first object, do nothing
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckProperty() == true)
            {
                Student student = new Student();
                student.Name = txtWriteName.Text;
                student.MSSV = Convert.ToInt32(txtWriteID.Text);
                student.Phone = txtWritePhone.Text;
                student.Course1 = Convert.ToSingle(txtWriteCourse1.Text);
                student.Course2 = Convert.ToSingle(txtWriteCourse2.Text);
                student.Course3 = Convert.ToSingle(txtWriteCourse3.Text);
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                student.Average = (float)Math.Round(student.Average, 2);
                txtFileContent.Text += student.Name + "\r\n"
                                  + student.MSSV + "\r\n"
                                  + student.Phone + "\r\n"
                                  + student.Course1 + "\r\n"
                                  + student.Course2 + "\r\n"
                                  + student.Course3 + "\r\n"
                                  + student.Average + "\r\n"
                                  + "\r\n";
                students.Add(student);
                pagenumbers.Add(pagenumbers.Count + 1);
                btnWrite_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Invalid Input.", "Notice");
                txtWriteName.Text = "";
                txtWriteID.Text = "";
                txtWritePhone.Text = "";
                txtWriteCourse1.Text = "";
                txtWriteCourse2.Text = "";
                txtWriteCourse3.Text = "";
            }
        }

        void Setup()
        {
            for (int index = 0; index < students.Count; index++)
            {
                pagenumbers.Add(index + 1);
                txtFileContent.Text += students[index].Name + "\r\n"
                              + students[index].MSSV + "\r\n"
                              + students[index].Phone + "\r\n"
                              + students[index].Course1 + "\r\n"
                              + students[index].Course2 + "\r\n"
                              + students[index].Course3 + "\r\n"
                              + students[index].Average + "\r\n"
                              + "\r\n";
            }
            ShowObject(0);
        }

        void ShowObject(int pagenumber)
        {
            txtReadName.Text = students[pagenumber].Name;
            txtReadID.Text = Convert.ToString(students[pagenumber].MSSV);
            txtReadPhone.Text = students[pagenumber].Phone;
            txtReadCourse1.Text = Convert.ToString(students[pagenumber].Course1);
            txtReadCourse2.Text = Convert.ToString(students[pagenumber].Course2);
            txtReadCourse3.Text = Convert.ToString(students[pagenumber].Course3);
            txtAverage.Text = Convert.ToString(students[pagenumber].Average);
            lbPageNumber.Text = Convert.ToString(pagenumbers[pagenumber]);
        }

        bool CheckProperty()
        {
            if ((Convert.ToInt32(txtWriteID.Text) < 10000000) || (Convert.ToInt64(txtWriteID.Text) > 99999999))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse1.Text) < 0) || (Convert.ToSingle(txtWriteCourse1.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse2.Text) < 0) || (Convert.ToSingle(txtWriteCourse2.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse3.Text) < 0) || (Convert.ToSingle(txtWriteCourse3.Text) > 10))
            {
                return false;
            }
            else if ((txtWritePhone.Text.Length != 10) || (txtWritePhone.Text[0] != '0'))
            {
                char a = txtWritePhone.Text[0];
                return false;
            }
            else
            {
                return true;
            }
        }

        void Serialized()
        {
            FileStream fsinput = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fsinput);
            Student student = new Student();
            while (reader.Peek() != -1)
            {
                student.Name = reader.ReadLine();
                if (reader.Peek() == -1) break;
                student.MSSV = Convert.ToInt32(reader.ReadLine());
                if (reader.Peek() == -1) break;
                student.Phone = reader.ReadLine();
                if (reader.Peek() == -1) break;
                student.Course1 = Convert.ToSingle(reader.ReadLine());
                if (reader.Peek() == -1) break;
                student.Course2 = Convert.ToSingle(reader.ReadLine());
                if (reader.Peek() == -1) break;
                student.Course3 = Convert.ToSingle(reader.ReadLine());
                if (reader.Peek() == -1) break;
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                student.Average = (float)Math.Round(student.Average, 2);
            }
            reader.Close();
            fsinput.Close();

            string jsonString = JsonSerializer.Serialize(student);
            File.WriteAllText("midput4.txt", jsonString);
        }

        void Deserialized()
        {
            string jsonString = File.ReadAllText("midput4.txt");
            Student student = JsonSerializer.Deserialize<Student>(jsonString);
            if (student != null && student.Name != null && student.Phone != null)
            {
                students.Add(student);
            }
        }

        [Serializable]
        class Student
        {
            public string? Name { get; set; }
            public int MSSV { get; set; }
            public string? Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Average { get; set; }
        }
    }
}
