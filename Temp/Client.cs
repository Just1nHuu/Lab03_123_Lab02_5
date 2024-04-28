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
using System.Net.Sockets;
using System.Net;

namespace Lab03_4
{
    public partial class Client : Form
    {

        private List<ViTriGheDat> VeDaDat;
        private List<cDanhGiaPhim> destination;
        private List<cPhim> phims;
        private NetworkStream ns;
        private TcpClient client;
        public Client()
        {
            InitializeComponent();

            phims = new List<cPhim>();
            destination = new List<cDanhGiaPhim>();
            VeDaDat = new List<ViTriGheDat>();
            

            string jsoncontentcPhim = File.ReadAllText("Input5.json");
            phims = JsonSerializer.Deserialize<List<cPhim>>(jsoncontentcPhim);

            string jsoncontentcTrangDanhGia = File.ReadAllText("Output5.json");
            destination = JsonSerializer.Deserialize<List<cDanhGiaPhim>>(jsoncontentcTrangDanhGia);


            ChonPhim.DataSource = phims;
            ChonPhim.DisplayMember = "Ten";

            if (ChonPhim.Items.Count > 0)
            {
                ChonPhim.SelectedIndex = 0;
            }


        }

        //Thực hiện bên server 
        //Gửi tuần tự Phim, Phong, HangGhe, SoGhe đến server
        //trả về bool true nếu vé chưa được đặt và false nếu vé đã được đặt
        private bool KiemTraVe(string ten, int phong, string hangGhe, int soGhe)
        {
            //gửi từng thông tin vé đến server
            byte[] byteSend = Encoding.UTF8.GetBytes(ten + "," + phong + "," + hangGhe + "," + soGhe + "\n");
            ns.Write(byteSend, 0, byteSend.Length);
            ns.Close();

            //Nhận kết quả từ server
            byte[] byteReceive = new byte[1024];
            ns.Read(byteReceive, 0, byteReceive.Length);
            string result = Encoding.UTF8.GetString(byteReceive);
            //Nếu vé đã được đặt thì trả về false
            if (result == "true")
            {
                return false;
            }
            return true;
        }
        //Thực hiện gửi thông tin vé đã đặt đến server
        private void SendVeDaDat()
        {
            //Gửi thông tin vé đã đặt đến server
            byte[] byteSend = Encoding.UTF8.GetBytes("VeDaDat\n");
            ns.Write(byteSend, 0, byteSend.Length);
        }
        //Khi chạy form Client thì sẽ gọi hàm này
        //Và kết nối đến server
        private void cBai05_Load(object sender, EventArgs e)
        {

            //Trưng bày thông tin phim và phòng chiếu
            cPhim selectedPhim = ChonPhim.SelectedItem as cPhim;
            Trong.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString() + " VND";


            HienThiViTriDaDat();
            HienThiDanhGia();

        }


        private int NhanHoaDon(string ten, int phong, string hangGhe, int soGhe)
        {
            //Gửi thông tin vé đã đặt đến server
            byte[] byteSend = Encoding.UTF8.GetBytes(ten + "," + phong + "," + hangGhe + "," + soGhe + "\n");
            ns.Write(byteSend, 0, byteSend.Length);
            //Nhận kết quả từ server
            byte[] byteReceive = new byte[1024];
            ns.Read(byteReceive, 0, byteReceive.Length);
            string result = Encoding.UTF8.GetString(byteReceive);
            return int.Parse(result);
        }
        private void GuiThongBao(string flag)
        {
            byte[] byteSend = Encoding.UTF8.GetBytes(flag + "\n");
            ns.Write(byteSend, 0, byteSend.Length);
        }
        //Khi d
        private void DatVe_Click(object sender, EventArgs e)
        {
            //Tạo đôi tượng phim và danh gia phim
            //Lấy thông tin phim đang chọn
            //
            cPhim selectPhim = ChonPhim.SelectedItem as cPhim;

            cDanhGiaPhim selectDanhGia = destination.First(d => d.Ten == selectPhim.Ten);

            int tongTien = 0;

            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();



            //Xác nhận lại có thực sự muốn mua vé không
            List<ViTriGheDat> ChuaDuocDat = new List<ViTriGheDat>();
            List<ViTriGheDat> DaDuocDat = new List<ViTriGheDat>();

            //Đếm số vé đã chọn để mua
            int SoVeDaChon = 0;

            int SoVeBanRa = 0;
            //Huỷ vé đã chọn và thông báo xác nhận có tiếp tục mua vé không
            string validSeats = "";
            string invalidSeats = "";
            //Khởi tạo flag kiểm tra vé hoặc đặt vé
            string flag = "0"; // mặc định là sẽ không đặt vé
            foreach (CheckBox checkBox in checkBoxes)
            {
                GuiThongBao(flag.ToString());
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
                "Ghế không hợp lệ: " + invalidSeats + "\n" +
                "Bạn có muốn mua vé " + validSeats + "không?",
                "Thông báo đơn hàng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                //Không đặt vé cũng không kiểm tra
                flag = "3\n";
                //gửi thông báo đến servr dạng string và có dấu \n để server biết là thông báo
                GuiThongBao(flag);

                return;
            }
            //Tiếp tục mua vé
            //Gửi thông báo 
            flag = "1\n";
            GuiThongBao(flag);

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


                    // Gửi thông tin đến Server để viết thông tin vé vào KiemTraVe.json
                    // Server sẽ tính toán tất cả và gửi về Output5.json và gửi lại cho client
                    // Gửi thông tin vé đã đặt đến server
                    tongTien += NhanHoaDon(selectPhim.Ten, int.Parse(ChonPhong.Text), hangGhe, soGhe);
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

            MessageBox.Show("Tổng hoá đơn " + tongTien.ToString() + " VND", "Hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.ns.Close();
            this.Close();
        }



        private void HienThiViTriDaDat()
        {
            label13.Text = "";
            var ve = VeDaDat.FirstOrDefault(v => v.Ten == ChonPhim.Text && v.Phong == int.Parse(ChonPhong.Text));
            int count = 0;
            foreach (var v in VeDaDat)
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
                        destination[i].TiLeBanRa = Math.Round((double)danhgia.SoLuongBanVe / (selectPhim.PhongChieu.Length * 15) * 100, 2);
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

        private void Connect_click(object sender, EventArgs e)
        {
            //Kết nối đến server qua địa chỉ IP và Port của server
            IPEndPoint IPserver = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client.Connect(IPserver);
            ns = client.GetStream();

        }
    }
}