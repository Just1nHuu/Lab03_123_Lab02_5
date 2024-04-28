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
    public partial class cBai07 : Form
    {
        public cBai07()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            int day;
            int month;

            day = int.Parse(tNgSinh.Text);
            month = int.Parse(tThSinh.Text);

            if ((month == 1 && day > 20) || (month == 2 && day < 20))
                tCung.Text = "Bảo Bình";
            else if ((month == 2 && day > 19) || (month == 3 && day < 21))
                tCung.Text = "Song Ngư";
            else if ((month == 3 && day > 20) || (month == 4 && day < 21))
                tCung.Text = "Bạch Dương";
            else if ((month == 4 && day > 20) || (month == 5 && day < 22))
                tCung.Text = "Kim Ngưu";
            else if ((month == 5 && day > 21) || (month == 6 && day < 22))
                tCung.Text = "Song Tử";
            else if ((month == 6 && day > 21) || (month == 7 && day < 23))
                tCung.Text = "Cử Giải";
            else if ((month == 7 && day > 22) || (month == 8 && day < 23))
                tCung.Text = "Sử Tử";
            else if ((month == 8 && day > 22) || (month == 9 && day < 24))
                tCung.Text = "Xử Nữ";
            else if ((month == 9 && day > 23) || (month == 10 && day < 24))
                tCung.Text = "Thiên Bình";
            else if ((month == 10 && day > 23) || (month == 11 && day < 23))
                tCung.Text = "Thần Nông";
            else if ((month == 11 && day > 22) || (month == 12 && day < 22))
                tCung.Text = "Nhân Mã";
            else if ((month == 12 && day > 21) || (month == 1 && day < 21))
                tCung.Text = "Ma Kết";
        }
    }
}
