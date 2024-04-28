using System.Net;
using System.Net.Sockets;

namespace Lab03_3
{
    public partial class Client : Form
    {
        private TcpClient TCPClient;
        public Client()
        {
            InitializeComponent();
            this.TCPClient = new TcpClient();
        }
        //Tạo đối tường TcpClient

        private void Connected(object sender, EventArgs e)
        {
            //Lấy IP và Port từ textbox nhập vào
            int.TryParse(textBox2.Text, out int port);
            if (!IPAddress.TryParse(textBox1.Text, out IPAddress ip))
            {
                MessageBox.Show("Invalid IP address");
                return;
            }    
            if (port <= 0||port > 65535)
            {
                MessageBox.Show("Invalid port");
                return;
            }
            //Kết nối đến IP và Port của server xác định 
            IPAddress ipAddress = IPAddress.Parse(textBox1.Text);
            IPEndPoint ipRemote = new IPEndPoint(ipAddress, port);
            this.TCPClient.Connect(ipRemote);
        }


        private void Send(object sender, EventArgs e)
        {
            //Tạo stream để nhận dữ liệu từ server
            NetworkStream ns = this.TCPClient.GetStream();

            //Ghi dữ liệu gửi cho server
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(richTextBox1.Text);

            //Gửi dữ liệu
            ns.Write(data, 0, data.Length);

            Array.Clear(data, 0, data.Length);  

            //Xoá dữ liệu trong textbox
            richTextBox1.Clear();

        }   

        private void Disconnect(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Quit");
            this.TCPClient.GetStream().Write(data, 0, data.Length);
            this.TCPClient.GetStream().Close(); 
            this.TCPClient.Close();
            this.Close();
        }
    }
}
