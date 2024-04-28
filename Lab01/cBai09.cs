using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class cBai09 : Form
    {

        string[] array;
        ulong size = 0;
        string input = "";
        int counter = 0;
        public cBai09()
        {
            InitializeComponent();
            array = new string[100];
        }

        private void Xoa__Click(object sender, EventArgs e)
        {
            Array.Clear(array, 0, array.Length);
            outputTxt.Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int value = generator.Next(1, counter + 1);

            ketquaTxt.Text = array[value];
        }

        private void Them_Click(object sender, EventArgs e)
        {
            counter++;
            input = inputTxt.Text;
            array[counter] = input;
            outputTxt.Text = outputTxt.Text + array[counter] + Environment.NewLine;
            inputTxt.Clear();
        }
    }
}
