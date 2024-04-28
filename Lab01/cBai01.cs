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
    public partial class cBai01 : Form
    {
        public cBai01()
        {
            InitializeComponent();
        }

        private void text_SoThuNhat(object sender, EventArgs e)
        {

        }

        private void text_SoThuHai(object sender, EventArgs e)
        {

        }

        private void button_Tinh(object sender, EventArgs e)
        {
            tTong.Text = (int.Parse(tHai.Text) + int.Parse(tMot.Text)).ToString();
        }

        private void TieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
