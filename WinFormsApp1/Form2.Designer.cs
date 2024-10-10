namespace WinFormsApp1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lb_sec = new Label();
            label3 = new Label();
            lb_min = new Label();
            pictureBox1 = new PictureBox();
            editQR = new Button();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(207, 49);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Bắt đầu đếm ngược";
            // 
            // lb_sec
            // 
            lb_sec.AutoSize = true;
            lb_sec.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_sec.Location = new Point(268, 92);
            lb_sec.Name = "lb_sec";
            lb_sec.Size = new Size(21, 15);
            lb_sec.TabIndex = 1;
            lb_sec.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 91);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // lb_min
            // 
            lb_min.AutoSize = true;
            lb_min.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_min.Location = new Point(243, 92);
            lb_min.Name = "lb_min";
            lb_min.Size = new Size(21, 15);
            lb_min.TabIndex = 3;
            lb_min.Text = "00";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(148, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 234);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // editQR
            // 
            editQR.BackColor = SystemColors.ActiveBorder;
            editQR.Location = new Point(230, 387);
            editQR.Name = "editQR";
            editQR.Size = new Size(75, 23);
            editQR.TabIndex = 5;
            editQR.Text = "Hủy QR";
            editQR.UseVisualStyleBackColor = false;
            editQR.Click += editQR_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 422);
            Controls.Add(editQR);
            Controls.Add(pictureBox1);
            Controls.Add(lb_min);
            Controls.Add(label3);
            Controls.Add(lb_sec);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_sec;
        private Label label3;
        private Label lb_min;
        private PictureBox pictureBox1;
        private Button editQR;
        private System.Windows.Forms.Timer timer;
    }
}