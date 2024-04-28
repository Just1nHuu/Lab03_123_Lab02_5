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
            client = new TcpClient();
            
        }

        //Hàm thực hiện kết nối đến server
        private void Client_Load(object sender, EventArgs e)
        {
        }

        //Thay đổi lựa chọn tên phim
        private void ChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Thay đổi lựa chọn phong chiếu
        private void ChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client.Connect(iPEndPoint);
        }
    }
}