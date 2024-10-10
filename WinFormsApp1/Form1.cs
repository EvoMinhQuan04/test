using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int tm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            string uniqueData = input + "_" + DateTime.Now.ToString() + "_" + Guid.NewGuid().ToString();

            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var qr1 = qr.CreateQrCode(uniqueData, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(qr1);
            var qrImage = code.GetGraphic(4);

            if(int.TryParse(txt_time.Text, out tm))
            {
                this.Hide();
                Form2 frm = new Form2(this, qrImage, tm);
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Hay nhap thoi gian hop le");
            }
        }
    }
}
