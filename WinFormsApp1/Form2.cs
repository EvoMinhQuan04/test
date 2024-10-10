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
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        private Image qrCodeImage;
        public int timeLeft;
        public Form2(Form1 form1, Image qrImage, int countdownTime)
        {
            parentForm = form1;
            qrCodeImage = qrImage;
            timeLeft = countdownTime;
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (sender != null)
            {
                timer.Start();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = qrCodeImage;
            }

        }

        private void editQR_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {

                // Update the label on Form2 to show the remaining time
                lb_min.Text = (timeLeft / 60).ToString();  // Minutes
                lb_sec.Text = (timeLeft % 60).ToString();  // Seconds
                timeLeft--;  // Decrease time left
            }
            else
            {
                // Time's up, stop the timer and take action
                timer.Stop();
                MessageBox.Show("Đã hoàn thành điểm danh và cập nhật danh sách.");
                this.Close();  // Close Form2 when time is up
            }
        }
    }
}
