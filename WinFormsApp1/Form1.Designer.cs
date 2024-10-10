namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            txt_time = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(244, 47);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin tạo mã QR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 108);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Thời gian hiện tại";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(241, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 155);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 3;
            label3.Text = "Nhập bán kính";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 202);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 5;
            label4.Text = "Nhập thời gian hợp lệ(giây)";
            // 
            // txt_time
            // 
            txt_time.Location = new Point(241, 197);
            txt_time.Name = "txt_time";
            txt_time.Size = new Size(248, 23);
            txt_time.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.ForestGreen;
            btnCreate.Location = new Point(200, 254);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(216, 63);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Xác nhận tạo QRCode";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 449);
            Controls.Add(btnCreate);
            Controls.Add(txt_time);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox txt_time;
        private Button btnCreate;
    }
}