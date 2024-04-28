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
    //Thực hiện
    public partial class Server : Form
    {
        private Socket socketClient;
        private List<ViTriGheDat> VeDaDat;
        private List<cDanhGiaPhim> destination;
        private List<cPhim> phims;
        public Server()
        {
            InitializeComponent();
            listView1.Scrollable = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Message", 1000);


            phims = new List<cPhim>();
            destination = new List<cDanhGiaPhim>();
            VeDaDat = new List<ViTriGheDat>();
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
        //Hàm thực lắng nghe kết nối từ client
        public void StartUnsafeThread()
        {
            int byteReceived = 0;
            // Khởi tạo mảng byte để nhận dữ liệu
            byte[] received = new byte[1];

            //Tạo socket bên gởi
            Socket ClientSocket;

            //Tạo socket lắng nghe
            Socket ListenerSocket = new Socket(
                //Trả  về họ địa chỉ của địa chỉ hiện hành
                //ở đây là địa chỉ IPv4 nên chọn AddressFamily.InterNetwork
                AddressFamily.InterNetwork,

                //Kiểu socket là stream,để nhận dữ liệu liên tục
                SocketType.Stream,

                //Giao thức truyền dữ liệu là TCP
                ProtocolType.Tcp);

            //Gán socket với địa chỉ IP và cổng
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            //Gán Socket địa chỉ và port phải lắng nghe vào máy chủ
            ListenerSocket.Bind(ipServer);

            //Bắt đầu lắng nghe
            ListenerSocket.Listen(-1);

            //Chấp nhận kết nối từ client
            ClientSocket = ListenerSocket.Accept();


            //Nhận dữ liệu từ client
            listView1.Items.Add("Server is running on 127.0.0.1:8080");
            listView1.Items.Add("Server is listening...");
            while (ClientSocket.Connected)
            {
                string text = "";
                //Nhận dữ liệu từ client đến dấu xuống hàng
                do
                {
                    byteReceived = ClientSocket.Receive(received);
                    text += Encoding.UTF8.GetString(received);
                } while (text[text.Length - 1] != '\n');
                text = "From client: " + text;
                listView1.Items.Add(new ListViewItem(text));
            }
        }


        private void Server_Load(object sender, EventArgs e)
        {

            //Kết nối đến client
            CheckForIllegalCrossThreadCalls = false;
            Thread TCPServer = new Thread(new ThreadStart(StartUnsafeThread));
            TCPServer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Thoát chương trình
            System.Environment.Exit(0);
        }
    }
}
