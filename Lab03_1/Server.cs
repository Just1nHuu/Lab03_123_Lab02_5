using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        public void serverThread()
        {
            int port;
            int.TryParse(textBox1.Text, out port);
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                
                IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, port);
                byte[] receiveByte = udpClient.Receive(ref RemoteIP);
                string returnData = Encoding.UTF8.GetString(receiveByte);
                string mess = RemoteIP.Address.ToString() + ": " + returnData.ToString();
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke((MethodInvoker)delegate
                    {
                        if(richTextBox1.Text == "")
                        {
                            richTextBox1.Text = mess;
                        }
                        else
                        {
                            richTextBox1.Text = richTextBox1.Text + "\n" + mess;
                        }
                    });
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread UDPServer = new Thread(new ThreadStart(serverThread));
            UDPServer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
