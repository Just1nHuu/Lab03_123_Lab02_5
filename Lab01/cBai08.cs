using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class cBai08 : Form
    {
        public cBai08()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            lsv_Subject.Items.Clear();
            txt_Average.Clear();
            txt_Max.Clear();
            txt_Min.Clear();
            txt_Pass.Clear();
            txt_Fail.Clear();
            txt_Classify.Clear();
            txt_hoten.Clear();

            String[] arrPoints = txt_Input.Text.Trim().Split(',');
            List<double[]> arrResult = new List<double[]>();

            double sumPoints, averagePoint;
            double maxPoint, minPoint, passCount;
            string hoTen;

            // Lấy tên sinh viên từ chuỗi đầu tiên trong mảng arrPoints
            hoTen = arrPoints[0];
            // Gán tên sinh viên vào txt_hoten
            txt_hoten.Text = hoTen;

            for (int i = 1; i < arrPoints.Length; i++) // Bắt đầu từ index 1 để bỏ qua phần tử tên
            {
                double point;
                bool isNumber = double.TryParse(arrPoints[i], out point);

                if (!isNumber || point < 0 || point > 10)
                {
                    lsv_Subject.Items.Clear();
                    txt_Input.Clear();
                    txt_Input.Focus();
                    MessageBox.Show("Điểm " + arrPoints[i] + " không hợp lệ\nĐiểm phải có giá trị từ 0 đến 10", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                string[] cols = new string[2];
                cols[0] = "Môn " + (i);
                cols[1] = point.ToString();

                arrResult.Add(new double[] { i, point });
                lsv_Subject.Items.Add(new ListViewItem(cols));
            }

            sumPoints = arrResult.Select(item => item[1]).Sum();
            averagePoint = sumPoints / arrResult.Count();

            maxPoint = arrResult.Select(item => item[1]).Max();
            minPoint = arrResult.Select(item => item[1]).Min();
            passCount = arrResult.FindAll(item => item[1] >= 5).Count();

            txt_Average.Text = averagePoint.ToString();
            txt_Pass.Text = passCount.ToString();
            txt_Fail.Text = (arrResult.Count() - passCount).ToString();

            txt_Max.Text = string.Join(", ",
                arrResult
                    .FindAll(item => item[1] == maxPoint)
                    .Select(item => "Môn " + item[0])
            );

            txt_Min.Text = string.Join(", ",
                arrResult
                    .FindAll(item => item[1] == minPoint)
                    .Select(item => "Môn " + item[0])
            );

            if (averagePoint >= 8 && arrResult.Find(item => item[1] < 6.5) == null)
                txt_Classify.Text = "Giỏi";
            else if (averagePoint >= 6.5 && arrResult.Find(item => item[1] < 5) == null)
                txt_Classify.Text = "Khá";
            else if (averagePoint >= 5 && arrResult.Find(item => item[1] < 3.5) == null)
                txt_Classify.Text = "Trung bình";
            else if (averagePoint >= 3.5 && arrResult.Find(item => item[1] < 2) == null)
                txt_Classify.Text = "Yếu";
            else
                txt_Classify.Text = "Kém";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "";
            txt_hoten.Text = "";
            txt_Average.Text = "";
            txt_Max.Text = "";
            txt_Min.Text = "";
            txt_Pass.Text = "";
            txt_Fail.Text = "";
            txt_Classify.Text = "";
            lsv_Subject.Items.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
