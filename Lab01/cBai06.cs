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
    public partial class cBai06 : Form
    {
        public cBai06()
        {
            InitializeComponent();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            int iSoA = int.Parse(SoA.Text);
            int iSoB = int.Parse(SoB.Text);
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Vui lòng chọn kiểu tính toán", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == "Bảng cửu chương")
            {
                if (iSoB < iSoA)
                {
                    MessageBox.Show("Vui lòng nhập số B lớn hơn số A", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    int So = iSoB - iSoA;
                    KetQua.Text = "Bảng cửu chương của " + So.ToString() + Environment.NewLine;
                    for (int i = 1; i < 11; i++)
                    {
                        KetQua.Text += So.ToString() + "*" + i.ToString() + "=" + (i * So) + Environment.NewLine;
                    }
                }
            }
            else
            {
                if(iSoA < iSoB)
                {
                    MessageBox.Show("Vui lòng nhập số A lớn hơn số B", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    int So = iSoA - iSoB;
                    int kq=1;
                    for (int i=So; i> 0;i-- )
                    {
                        kq = kq * i;
                    }
                    KetQua.Text = "(A-B)!" + "=" +kq.ToString() +  Environment.NewLine;
                  
                    int SoCong=0;
                    for (int j=1; j<=iSoB;j++)
                    {
                        int SoNhan=1;
                        for (int h=1;h<=j;h++)
                        {
                            SoNhan = iSoA * SoNhan;
                        }
                        SoCong = SoNhan + SoCong;
                    }
                    KetQua.Text += "Tổng S = " + SoCong.ToString()+ Environment.NewLine;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            KetQua.Text = null;
            SoA.Text = null;
            SoB.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
