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
    public partial class cBai02 : Form
    {
        public cBai02()
        {
            InitializeComponent();
        }
        // So
        private void click_Tim(object sender, EventArgs e)
        {
            int iSoMot = int.Parse(SoMot.Text);
            int iSoHai = int.Parse(SoHai.Text);
            int iSoBa = int.Parse(SoBa.Text);
            if (iSoMot==iSoHai && iSoHai==iSoBa)
            {
                MessageBox.Show("Vui lòng không nhập trùng tất cả số","Error",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            }
            if (iSoMot != iSoHai && iSoMot != iSoBa)
            {
                if (iSoMot > iSoHai)
                {
                    if (iSoMot < iSoBa)
                    {
                        SoLon.Text = iSoBa.ToString();
                        SoBe.Text = iSoHai.ToString();
                    }
                    else if (iSoBa < iSoHai)
                    {
                        SoBe.Text = iSoBa.ToString();
                        SoLon.Text = iSoMot.ToString();

                    }
                }
                else if (iSoHai > iSoMot)
                {
                    if (iSoHai < iSoBa)
                    {
                        SoLon.Text = iSoBa.ToString();
                        SoBe.Text = iSoMot.ToString();
                    }
                    else if (iSoBa < iSoMot)
                    {
                        SoBe.Text = iSoBa.ToString();
                        SoLon.Text = iSoHai.ToString();
                    }
                }
            }
            else
            {
                if(iSoMot > iSoHai)                //iSoHai=iSoBa || iSoMot=iSoBa
                {
                    SoBe.Text = iSoHai.ToString();
                    SoLon.Text = iSoMot.ToString();
                }
                else if (iSoMot > iSoBa)          //iSoHai=iSoBa || iSoMot=iSoHai
                {
                    SoBe.Text = iSoBa.ToString();
                    SoLon.Text = iSoMot.ToString();
                }
                else if (iSoBa > iSoMot)        //iSoBa=iSoHai ||iSoHai=iSoMot
                {
                    SoBe.Text = iSoMot.ToString();
                    SoLon.Text = iSoBa.ToString();
                }
                else                            
                {
                    SoBe.Text = iSoHai.ToString();
                    SoLon.Text = iSoBa.ToString();
                }
            }
        }

        private void click_Xoa(object sender, EventArgs e)
        {

        }

        private void click_Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
