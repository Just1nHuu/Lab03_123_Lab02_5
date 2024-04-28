using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class cBai01 : Form
    {
        public cBai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Txt|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath= ofd.FileName;
                FilePath.Text = filepath;
                FileStream fileStream = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fileStream);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fileStream.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog ifd = new SaveFileDialog();
            if (ifd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = richTextBox1.Text.ToUpper();

                string filepath= ifd.FileName;
                FilePath.Text = filepath;
                FileStream fileStream = new FileStream(ifd.FileName, FileMode.OpenOrCreate);
                StreamWriter sr = new StreamWriter(fileStream);
                sr.Write(richTextBox1.Text);
                sr.Close();
                fileStream.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
