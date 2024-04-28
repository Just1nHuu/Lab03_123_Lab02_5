using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class cBai03 : Form  
    {
        public cBai03()
        {
            InitializeComponent();
        }

        private void click_Doc(object sender, EventArgs e)
        {
           
                int iSo = int.Parse(So.Text);

                switch (iSo)
                {
                    case 0: KetQua.Text = "Không"; break;
                    case 1: KetQua.Text = "Một"; break;
                    case 2: KetQua.Text = "Hai"; break;
                    case 3: KetQua.Text = "ba"; break;
                    case 4: KetQua.Text = "bốn"; break;
                    case 5: KetQua.Text = "Năm"; break;
                    case 6: KetQua.Text = "Sáu"; break;
                    case 7: KetQua.Text = "Bảy"; break;
                    case 8: KetQua.Text = "Tám"; break;
                    case 9: KetQua.Text = "Chín"; break;
                    default: break;
                }
            
        }

        private void click_Xoa(object sender, EventArgs e)
        {
            KetQua.Text = null;
            So.Text = null;
        }

        private void click_Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
