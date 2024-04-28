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
namespace Lab03_1
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port;
            int.TryParse(textBox2.Text, out port);
            UdpClient udpClient = new UdpClient();
            Byte[] data = Encoding.UTF8.GetBytes(richTextBox1.Text);
            udpClient.Send(data, data.Length, textBox1.Text, port);
        }

    }
}
