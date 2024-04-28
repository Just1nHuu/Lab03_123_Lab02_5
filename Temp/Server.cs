using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text.Json;
using System.Security.Claims;
using System.Web;
namespace Lab03_4
{
    public partial class Server : Form
    {
        private Socket socketClient;

        private List<ViTriGheDat> VeDaDat;
        private List<cDanhGiaPhim> destination;
        private List<cPhim> phims;
        public Server()
        {
            InitializeComponent();

            phims = new List<cPhim>();
            destination = new List<cDanhGiaPhim>();
            VeDaDat = new List<ViTriGheDat>();


            //Đọc dữ liệu từ file Input5.JSON
            string jsonPhim = System.IO.File.ReadAllText("Input5.JSON");
            phims = JsonSerializer.Deserialize<List<cPhim>>(jsonPhim);

            //Đọc dữ liệu từ file cDanhDanhGia.JSON
            string jsonDanhGia = System.IO.File.ReadAllText("Output5.JSON");
            destination = JsonSerializer.Deserialize<List<cDanhGiaPhim>>(jsonDanhGia);
            //Đọc dữ liệu từ file KiemTraVe.JSON
            string jsonVeDaDat = System.IO.File.ReadAllText("KiemTraVe.JSON");
            VeDaDat = JsonSerializer.Deserialize<List<ViTriGheDat>>(jsonVeDaDat);


        }

        //Khi ta chạy form Server thì sẽ gọi hàm này
        private void Server_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartSafeThread);
            thread.Start();
        }

        private void Listener()
        {
            //Tạo socket lắng nghe
            Socket socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            //Tạo địa chỉ IP và Port tại máy chủ
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            //Gán socket lắng nghe với địa chỉ IP của máy và Port
            socketListener.Bind(ipServer);

            //Bắt đầu lắng nghe
            socketListener.Listen(-1);

            //Chấp nhận kết nối từ client
            this.socketClient = socketListener.Accept();


        }

        //Xử lí tách text từ client
        //Tách text từ client thành các thuộc tính của class ViTriGheDat
        private ViTriGheDat XuLyDuLieu(string text)
        {
            //Tách text từ client thành các thuộc tính của class ViTriGheDat
            string[] arr = text.Split(',');

            //Tách các thuộc tính của class ViTriGheDat
            ViTriGheDat vt = new ViTriGheDat();
            vt.Ten = arr[0];
            vt.Phong = int.Parse(arr[1]);
            vt.HangGhe = arr[2];
            vt.SoGhe = int.Parse(arr[3]);
            return vt;
        }
        private bool KiemTraVeDaDatChua (string text)
        {
            ViTriGheDat vt = XuLyDuLieu("text");
            // Kiểm tra xem có vé nào trong danh sách VeDaDat có hangGhe và soGhe tương ứng hay không
            var ve = VeDaDat.FirstOrDefault(v => v.Ten == vt.Ten && v.HangGhe == vt.HangGhe && v.SoGhe == vt.SoGhe && v.Phong == vt.SoGhe);

            // Nếu không tìm thấy vé nào, trả về true (vé chưa được đặt)
            if (ve == null)
            {
                return true;
            }

            // Nếu tìm thấy vé, kiểm tra xem vé đã được đặt hay chưa
            return false;
        }

        //Nhận thông báo tiếp tục đặt vé từ client
        private bool TiepTucDatVe()
        {
            byte[] bytes = new byte[1024];
            //Nhận thông báo từ client
            int bytesRec = socketClient.Receive(bytes);
            string text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            //Nếu text từ client là "OK" thì trả về true
            if (text == "OK")
            {
                return true;
            }
            //Nếu text từ client không phải là "OK" thì trả về false
            return false;
        }
        //Thực hiện việc đặt vé, tính toán, thêm vào file KiemTraVe.JSON
        private void DatVe(ViTriGheDat vt)
        {
            cPhim selectPhim = phims.First(p => p.Ten == vt.Ten);

            cDanhGiaPhim selectDanhGia = destination.First(d => d.Ten == selectPhim.Ten);


            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            int tongTien = 0;
            int giaVe = selectPhim.GiaVe;
            int SoVeBanRa = 0;
            //Thêm vé vào danh sách VeDaDat
            VeDaDat.Add(vt);
            //Tính toán hoá đơn vé
            //Tìm phim tương ứng với vé đã đặt
            cPhim phim = phims.FirstOrDefault(p => p.Ten == vt.Ten);
            
            if (vt.SoGhe == 1 || vt.SoGhe == 5)
            {
                tongTien += giaVe / 2;
            }
            else
            {
                if (vt.HangGhe.Equals("B"))
                {
                    tongTien += giaVe * 2;
                }
                else
                {
                    tongTien += giaVe;
                }
            }


            //Ghi danh sách destination vào file KiemTraVe.JSON
            string json = JsonSerializer.Serialize(destination);
            System.IO.File.WriteAllText("KiemTraVe.JSON", json);
        }

        // Xử lý dữ liệu nhận được từ client từ file KiemTraVe.JSON từ file nhận client
        private void StartSafeThread()
        {
            Listener();
            //Khởi tạo chứa dữ liệu nhận được từ client
            Byte[] DataByte;
            int ByteReceived = 0;
            //Khởi tạo mảng byte chứa kích thước dữ liệu nhận được từ client
            byte[] SizeData = new byte[4];
            int ByteSizeReceive = 0;
            string ACK;

            
            while (socketClient.Connected)
            {
                // Nhận dữ liệu từ client một chuối các kí tự gồm tất cả các thuộc tính ViTriGheDat cách nhau bởi dấu , và khi kết thúc sẽ xuống dòng
                // text = dữ liệu nhận được từ client tinhs từ đầu đến kí tự xuống dòng
                string text = "";
                do
                {
                    //Nhận kích thước của dữ liệu từ client
                    ByteSizeReceive = socketClient.Receive(SizeData);
                    //chuyển mảng byte nhận được sang dạng int
                    int size = BitConverter.ToInt32(SizeData, 0);
                    //Khởi tạo mảng byte để nhận dữ liệu
                    DataByte = new Byte[ByteSizeReceive];

                    //Nhận dữ liệu từ client và lưu vào mảng DataByte
                    //Lưu trữ số byte mới nhận được trong DataByte từ client vào biến ByteReceived
                    ByteReceived = socketClient.Receive(DataByte);
                    if (ByteReceived != ByteSizeReceive)
                    {
                        //Nếu số byte nhận được khác với số byte cần nhận thì gửi lại ACK
                        ACK = "NACK";
                        socketClient.Send(Encoding.UTF8.GetBytes(ACK));
                        break;
                        
                    }
                    else
                    {
                        //Nếu số byte nhận được bằng với số byte cần nhận thì gửi lại ACK
                        ACK = "ACK";
                        socketClient.Send(Encoding.UTF8.GetBytes(ACK));
                    }

                    //Chuyển mảng byte nhận được sang dạng chuỗi
                    //Giải mã mảng byte nhận được từ client là DataByte từ vị trí 0 đến ByteReceived
                    text += Encoding.UTF8.GetString(DataByte, 0, ByteReceived);
                    } while (text[text.Length - 1] != '\n');
                if (ACK == "NACK")
                {
                    text = "Không nhận được dữ liệu từ client hoặc dữ liệu bị lỗi";
                    listView1.Items.Add(new ListViewItem(text));
                }
                else
                {
                    text = "From client: " + text;
                    listView1.Items.Add(new ListViewItem(text));
                }
                //Kiểm tra xem text từ client có phải là thông báo kiểm tra vé đã đặt hay chưa hay không
                //Chỉ kiểm tra vé đã đặt hay chưa, chưa thực hiện việc đặt vé
                //Xử lí dữ liệu nhận được từ client
                //Nhận dữ liệu thông báo từ client

                

                //Nhận thông báo từ client
                ByteReceived = socketClient.Receive(DataByte);
                string ThongBao = Encoding.ASCII.GetString(DataByte, 0, ByteReceived);

                if (ThongBao == "1")
                {
                    //thực hiện việc đặt vé nếu client gửi thông báo OK
                    if (TiepTucDatVe())
                    {
                        DatVe(XuLyDuLieu(text));
                    }
                }
                else if(ThongBao == "0")
                {
                    bool flag = KiemTraVeDaDatChua(text);
                    //Tạo mảng byte để gửi dữ liệu
                    DataByte = Encoding.ASCII.GetBytes(flag.ToString());
                    //Gửi dữ liệu cho client
                    socketClient.Send(DataByte);
                }
            }
        }
    }
}
