using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class cDanhSach : Form
    {
        public cDanhSach()
        {
            InitializeComponent();
        }
        
        private void Bai01_Click(object sender, EventArgs e)
        {
            cBai01 bai1 = new cBai01();
            bai1.ShowDialog();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            cBai02 bai2 = new cBai02();
            bai2.ShowDialog();
        }


        private void Bai04_Click(object sender, EventArgs e)
        {
            cBai04 bai4 = new cBai04();
            bai4.ShowDialog();
        }
        
        private void Bai05_Click(object sender, EventArgs e)
        {
            cBai05 bai5 = new cBai05();
            bai5.ShowDialog();
        }

        
        private void Bai06_Click(object sender, EventArgs e)
        {
            cBai06 bai6 = new cBai06();
            bai6.ShowDialog();
        }
        
        private void Bai07_Click(object sender, EventArgs e)
        {
            cBai07 bai7 = new cBai07();
            bai7.ShowDialog();
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
