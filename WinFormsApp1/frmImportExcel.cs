using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace WinFormsApp1
{
    public partial class frmImportExcel : Form
    {
        private OleDbConnection? conn;
        private frmMain mainForm;
        public frmImportExcel(frmMain frm)
        {
            InitializeComponent();
            this.mainForm = frm;
            this.FormClosing += frmImportExcel_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = System.IO.Path.GetExtension(filePath);
                string connString = "";

                if (extension == ".xls")
                {
                    // Excel 97-03
                    connString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={filePath};Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
                }
                else if (extension == ".xlsx")
                {
                    // Excel 07 trở lên
                    connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'";
                }
                else
                {
                    MessageBox.Show("Định dạng file không được hỗ trợ.");
                    return;
                }

                try
                {
                    conn = new OleDbConnection(connString);
                    conn.Open();

                    DataTable? dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    if (dtSheet == null || dtSheet.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sheet nào trong file Excel.");
                        conn.Close();
                        return;
                    }

                    comboBox1.Items.Clear();

                    foreach (DataRow row in dtSheet.Rows)
                    {
                        string? sheetName = row["TABLE_NAME"]?.ToString();

                        if (!string.IsNullOrEmpty(sheetName))
                        {
                            comboBox1.Items.Add(sheetName);
                        }
                    }

                    if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Không có sheet nào trong file Excel.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }



            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Chưa kết nối đến file Excel.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sheet hợp lệ.");
                return;
            }

            string? sheetName = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrEmpty(sheetName))
            {
                MessageBox.Show("Vui lòng chọn sheet hợp lệ.");
                return;
            }

            try
            {
                sheetName = sheetName.Replace("'", "''");

                string query = $"SELECT * FROM [{sheetName}]";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable? dt = dataGridView1.DataSource as DataTable;

            if (dt != null)
            {
                mainForm.SetDataGridViewData(dt.Copy());
                this.Close();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để chuyển.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmImportExcel_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
