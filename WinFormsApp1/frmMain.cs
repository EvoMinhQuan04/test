using System.Data;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        private frmImportExcel? frmImportExcel;
        public frmMain()
        {
            InitializeComponent();
        }
        //nhận dữ liệu từ form excel
        public void SetDataGridViewData(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //T?o QR
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xu?t file
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Thêm
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //S?a
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nh?p gi? t? 00 ??n 23
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmImportExcel == null || frmImportExcel.IsDisposed)
            {
                frmImportExcel = new frmImportExcel(this); // Truyền 'this' vào Form2

                frmImportExcel.FormClosed += frmImportExcel_FormClosed;

                frmImportExcel.Show();
            }
            else
            {
                frmImportExcel.BringToFront();
            }
            //frmImportExcel frm = new frmImportExcel();
            //frm.ShowDialog();
            //Nh?p file
        }

        private void frmImportExcel_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmImportExcel = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Xóa
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //T́m ki?m l?p
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nh?p phút t? 00 ??n 60
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //hi?n th? file excel
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //k?t thúc ?i?m danh
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //l?u
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //thoát ?ng d?ng
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // mă qr
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //cho nh?p ngày t? calendar
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // l?y t?ng t? file excel
        }
    }
}
