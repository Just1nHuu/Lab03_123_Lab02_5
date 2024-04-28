using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Authentication;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class cBai05 : Form
    {
        class cPhim
        {
            [JsonPropertyName("TenPhim")]
            public required string Ten { get; set; }
            [JsonPropertyName("GiaVeChuan")]
            public int GiaVe { get; set; }
            [JsonPropertyName("PhongChieu")]
            public int[]? PhongChieu { get; set; }
        }
        class cDanhGiaPhim
        {
            [JsonPropertyName("TenPhim")]
            public required string Ten { get; set; }
            [JsonPropertyName("SoLuongBanVe")]
            public int SoLuongBanVe { get; set; }
            [JsonPropertyName("SoLuongTonVe")]
            public int SoLuongTonVe { get; set; }
            [JsonPropertyName("TiLeBanVe")]
            public double TiLeBanRa { get; set; }
            [JsonPropertyName("DoanhThu")]
            public int DoanhThu { get; set; }
            [JsonPropertyName("XepHangDoanhThu")]
            public int XepHangDoanhThu { get; internal set; }
        }
        class ViTriGheDat
        {
            public string Ten { get; set; }
            public int Phong { get; set; }
            public string HangGhe { get; set; }
            public int SoGhe { get; set; }
        }

        List<cPhim> phims = new List<cPhim>();
        List<cDanhGiaPhim> destination = new List<cDanhGiaPhim>();
        List<ViTriGheDat> VeDaDat = new List<ViTriGheDat>();

        public cBai05()
        {
            InitializeComponent();

            string jsoncontentcPhim = File.ReadAllText("Input5.json");
            phims = JsonSerializer.Deserialize<List<cPhim>>(jsoncontentcPhim);

            string jsoncontentcKiemTraVe = File.ReadAllText("KiemTraVe.json");
            VeDaDat = JsonSerializer.Deserialize<List<ViTriGheDat>>(jsoncontentcKiemTraVe);
            
            string jsoncontentcTrangDanhGia = File.ReadAllText("Output5.json");
            destination = JsonSerializer.Deserialize<List<cDanhGiaPhim>>(jsoncontentcTrangDanhGia);


            ChonPhim.DataSource = phims;
            ChonPhim.DisplayMember = "Ten";

            if (ChonPhim.Items.Count > 0)
            {
                ChonPhim.SelectedIndex = 0;
            }

            
        }

        private bool KiemTraVe(string ten, int phong, string hangGhe, int soGhe)
        {
            // Kiểm tra xem có vé nào trong danh sách VeDaDat có hangGhe và soGhe tương ứng hay không
            var ve = VeDaDat.FirstOrDefault(v => v.Ten == ten && v.HangGhe == hangGhe && v.SoGhe == soGhe && v.Phong == phong);

            // Nếu không tìm thấy vé nào, trả về true (vé chưa được đặt)
            if (ve == null)
            {
                return true;
            }

            // Nếu tìm thấy vé, kiểm tra xem vé đã được đặt hay chưa
            return false;
        }

        

        private void DatVe_Click(object sender, EventArgs e)
        {
            cPhim selectPhim = ChonPhim.SelectedItem as cPhim;

            cDanhGiaPhim selectDanhGia = destination.First(d => d.Ten == selectPhim.Ten);

           
            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            int tongTien = 0;
            int giaVe = selectPhim.GiaVe;
            int SoVeBanRa = 0;
            
            List<ViTriGheDat> ChuaDuocDat= new List<ViTriGheDat>();
            List<ViTriGheDat> DaDuocDat= new List<ViTriGheDat>();

            //Đếm số vé đã chọn để mua
            int SoVeDaChon = 0;
            //Huỷ vé đã chọn và thông báo xác nhận có tiếp tục mua vé không
            string validSeats = "";
            string invalidSeats = "";
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    //MessageBox.Show(checkBox.Name);
                    string hangGhe = checkBox.Name.Split('_')[0];
                    int soGhe = int.Parse(checkBox.Name.Split('_')[1]);
                    if (KiemTraVe(selectPhim.Ten, int.Parse(ChonPhong.Text), hangGhe, soGhe) == false)
                    {
                        invalidSeats += hangGhe + soGhe + " ";
                        checkBox.Checked = false;
                    }
                    else
                    {
                        validSeats += hangGhe + soGhe + " ";
                        checkBox.Checked = true;
                    }
                    SoVeDaChon++;
                }
            }

            if (MessageBox.Show(
                "Số lượng vé đã chọn:  " + SoVeDaChon + " vé\n" +
                "Ghế hợp lệ: " + validSeats + "\n" +
                "Ghế không hợp lệ: " + invalidSeats +"\n" +
                "Bạn có muốn mua vé " + validSeats + "không?",
                "Thông báo đơn hàng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    //MessageBox.Show(checkBox.Name);
                    string hangGhe = checkBox.Name.Split('_')[0];
                    int soGhe = int.Parse(checkBox.Name.Split('_')[1]);

                    VeDaDat.Add(new ViTriGheDat
                    {
                        Ten = selectPhim.Ten,
                        Phong = int.Parse(ChonPhong.Text),
                        HangGhe = hangGhe,
                        SoGhe = soGhe,
                    });


                    // Viết thông tin vé vào KiemTraVe.json
                    string DatVe = JsonSerializer.Serialize(VeDaDat, options);
                    File.WriteAllText("KiemTraVe.json", DatVe);
                    //Hiển thị thông tin vé đã đặt

                    if (soGhe == 1 || soGhe == 5)
                    {
                        tongTien += giaVe / 2;
                    }
                    else
                    {
                        if (hangGhe.Equals("B"))
                        {
                            tongTien += giaVe * 2;
                        }
                        else
                        {
                            tongTien += giaVe;
                        }
                    }
                    SoVeBanRa++;
                    checkBox.Checked = false;
                }
            }
            selectDanhGia.SoLuongBanVe += SoVeBanRa;
            selectDanhGia.SoLuongTonVe -= SoVeBanRa;
            selectDanhGia.DoanhThu += tongTien;


            // Write destination to output5.json
            string DanhGia = JsonSerializer.Serialize(destination, options);
            File.WriteAllText("Output5.json", DanhGia);

            HienThiViTriDaDat();
            HienThiDanhGia();



            MessageBox.Show("Tổng hoá đơn " + tongTien.ToString() + " VND","Hoá đơn",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cBai05_Load(object sender, EventArgs e)
        {
            //Trưng bày thông tin phim và phòng chiếu
            cPhim selectedPhim = ChonPhim.SelectedItem as cPhim;
            Trong.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString() + " VND";

            
            HienThiViTriDaDat();
            HienThiDanhGia();

        }

        private void ChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPhim selectedPhim = ChonPhim.SelectedItem as cPhim;
            ChonPhong.DataSource = selectedPhim.PhongChieu;
            Trong.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString() + " VND";
            label9.Text = selectedPhim.Ten;
            HienThiViTriDaDat();
            HienThiDanhGia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            //Đặt lại mới tất cả trừ file dữ liệu Input5.json
            // Reset all checkboxes
            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }
            // Reset file KiemTraVe.json
            VeDaDat.Clear();
            File.WriteAllText("KiemTraVe.json", "[]");

            // Reset destination
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            destination = phims.Select(d => new cDanhGiaPhim
            {
                Ten = d.Ten,
                SoLuongBanVe = 0,
                SoLuongTonVe = d.PhongChieu.Length*15,
                TiLeBanRa = 0,
                DoanhThu = 0

            }).ToList();

            string DanhGia = JsonSerializer.Serialize(destination, options);
            File.WriteAllText("Output5.json", DanhGia);
            HienThiDanhGia();

            label13.Text = "Ghế đã đặt: chưa có";

            HienThiViTriDaDat();
        }

        private void HienThiViTriDaDat()
        {
            label13.Text = "";
            var ve = VeDaDat.FirstOrDefault(v => v.Ten == ChonPhim.Text && v.Phong == int.Parse(ChonPhong.Text));
            int count = 0;
            foreach ( var v in VeDaDat )
            {
                if (v.Ten == ChonPhim.Text && v.Phong == int.Parse(ChonPhong.Text))
                {
                    count++;
                }
            }
            if (ve == null)
            {
                label13.Text = "Ghế đã đặt: chưa có";
            }
            else if (count == 15)
            {
                label13.Text = "Ghế đã đặt: full";
            }
            else if (VeDaDat.Count > 0)
            {
                    string str = "Ghế đã đặt: ";
                    //Với mỗi vé đã đặt, nếu vé đó là vé của phim và phòng đang chọn thì hiển thị vị trí ghế
                    foreach (ViTriGheDat ve1 in VeDaDat)
                    {
                        if (ve1.Ten == ChonPhim.Text && ve1.Phong == int.Parse(ChonPhong.Text))
                        {
                            str += ve1.HangGhe + ve1.SoGhe + " ";
                        }
                    }
                    label13.Text = str;
                
            }
        }

        private void HienThiDanhGia()
        {

            //Hiển thị thông tin đánh giá của phim
            //Lấy thông tin phim đang chọn
            cPhim selectPhim = ChonPhim.SelectedItem as cPhim;

            //Xếp hạng các phim theo doanh thu, nếu không có doanh thu thì xếp hạng = 0
            foreach (cDanhGiaPhim danhgia in destination)
            {

                if (danhgia.DoanhThu == 0)
                {
                    danhgia.XepHangDoanhThu = 0;
                }
                else
                {
                    destination = destination.OrderByDescending(d => d.DoanhThu).ToList();
                    for (int i = 0; i < destination.Count; i++)
                    {
                        destination[i].TiLeBanRa = Math.Round((double)danhgia.SoLuongBanVe / (selectPhim.PhongChieu.Length * 15)*100,2);
                        destination[i].XepHangDoanhThu = i + 1;
                    }
                }
            }

            cDanhGiaPhim selectedDanhGia = destination.First(d => d.Ten == selectPhim.Ten);
            label9.Text = selectedDanhGia.Ten;
            textBox1.Text = selectedDanhGia.XepHangDoanhThu.ToString();
            textBox2.Text = selectedDanhGia.SoLuongBanVe.ToString();
            textBox3.Text = selectedDanhGia.SoLuongTonVe.ToString();
            textBox4.Text = selectedDanhGia.TiLeBanRa.ToString();
            textBox5.Text = selectedDanhGia.DoanhThu.ToString();
        
        }
            private void ChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiViTriDaDat();
        }
    }
}