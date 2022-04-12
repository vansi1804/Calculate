namespace CalculateProfit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.tbMoiLenh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSoNgay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVonBanDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTienMoiLenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVonCuoiNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinh = new System.Windows.Forms.Button();
            this.tbLoiNhuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Controls.Add(this.tbMoiLenh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbSoNgay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbRut);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.btnTinh);
            this.panel1.Controls.Add(this.tbLoiNhuan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbVon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 671);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(749, 31);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayBatDau.TabIndex = 17;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(749, 72);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayKetThuc.TabIndex = 18;
            // 
            // tbMoiLenh
            // 
            this.tbMoiLenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoiLenh.Location = new System.Drawing.Point(242, 151);
            this.tbMoiLenh.Multiline = true;
            this.tbMoiLenh.Name = "tbMoiLenh";
            this.tbMoiLenh.Size = new System.Drawing.Size(285, 35);
            this.tbMoiLenh.TabIndex = 5;
            this.tbMoiLenh.Text = "0.04";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 35);
            this.label7.TabIndex = 16;
            this.label7.Text = "% Mỗi lệnh";
            // 
            // tbSoNgay
            // 
            this.tbSoNgay.Enabled = false;
            this.tbSoNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoNgay.Location = new System.Drawing.Point(749, 112);
            this.tbSoNgay.Multiline = true;
            this.tbSoNgay.Name = "tbSoNgay";
            this.tbSoNgay.Size = new System.Drawing.Size(206, 35);
            this.tbSoNgay.TabIndex = 8;
            this.tbSoNgay.Text = "1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số ngày";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // tbRut
            // 
            this.tbRut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRut.Location = new System.Drawing.Point(242, 110);
            this.tbRut.Multiline = true;
            this.tbRut.Name = "tbRut";
            this.tbRut.Size = new System.Drawing.Size(285, 35);
            this.tbRut.TabIndex = 4;
            this.tbRut.Text = "45";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rút";
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvNgay,
            this.dgvVonBanDau,
            this.dgvSoTienMoiLenh,
            this.dgvLai,
            this.dgvVonCuoiNgay,
            this.dgvGhiChu});
            this.dgv.Location = new System.Drawing.Point(3, 236);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1521, 432);
            this.dgv.TabIndex = 9;
            // 
            // dgvSTT
            // 
            this.dgvSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvSTT.HeaderText = "STT";
            this.dgvSTT.MinimumWidth = 8;
            this.dgvSTT.Name = "dgvSTT";
            this.dgvSTT.ReadOnly = true;
            this.dgvSTT.Width = 74;
            // 
            // dgvNgay
            // 
            this.dgvNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvNgay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNgay.FillWeight = 140F;
            this.dgvNgay.HeaderText = "Ngày";
            this.dgvNgay.MinimumWidth = 8;
            this.dgvNgay.Name = "dgvNgay";
            this.dgvNgay.ReadOnly = true;
            this.dgvNgay.Width = 140;
            // 
            // dgvVonBanDau
            // 
            this.dgvVonBanDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvVonBanDau.HeaderText = "Vốn ban đầu";
            this.dgvVonBanDau.MinimumWidth = 8;
            this.dgvVonBanDau.Name = "dgvVonBanDau";
            this.dgvVonBanDau.ReadOnly = true;
            this.dgvVonBanDau.Width = 150;
            // 
            // dgvSoTienMoiLenh
            // 
            this.dgvSoTienMoiLenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSoTienMoiLenh.FillWeight = 125F;
            this.dgvSoTienMoiLenh.HeaderText = "Số tiền mỗi lệnh";
            this.dgvSoTienMoiLenh.MinimumWidth = 8;
            this.dgvSoTienMoiLenh.Name = "dgvSoTienMoiLenh";
            this.dgvSoTienMoiLenh.ReadOnly = true;
            this.dgvSoTienMoiLenh.Width = 125;
            // 
            // dgvLai
            // 
            this.dgvLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvLai.HeaderText = "Lãi";
            this.dgvLai.MinimumWidth = 8;
            this.dgvLai.Name = "dgvLai";
            this.dgvLai.ReadOnly = true;
            this.dgvLai.Width = 150;
            // 
            // dgvVonCuoiNgay
            // 
            this.dgvVonCuoiNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvVonCuoiNgay.HeaderText = "Vốn cuối ngày";
            this.dgvVonCuoiNgay.MinimumWidth = 8;
            this.dgvVonCuoiNgay.Name = "dgvVonCuoiNgay";
            this.dgvVonCuoiNgay.ReadOnly = true;
            this.dgvVonCuoiNgay.Width = 150;
            // 
            // dgvGhiChu
            // 
            this.dgvGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGhiChu.HeaderText = "Ghi Chú";
            this.dgvGhiChu.MinimumWidth = 8;
            this.dgvGhiChu.Name = "dgvGhiChu";
            this.dgvGhiChu.ReadOnly = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(1092, 31);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(144, 116);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // tbLoiNhuan
            // 
            this.tbLoiNhuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoiNhuan.Location = new System.Drawing.Point(242, 69);
            this.tbLoiNhuan.Multiline = true;
            this.tbLoiNhuan.Name = "tbLoiNhuan";
            this.tbLoiNhuan.Size = new System.Drawing.Size(285, 35);
            this.tbLoiNhuan.TabIndex = 3;
            this.tbLoiNhuan.Text = "0.1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lợi nhuận (%/ngày)";
            // 
            // tbVon
            // 
            this.tbVon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVon.Location = new System.Drawing.Point(242, 28);
            this.tbVon.Multiline = true;
            this.tbVon.Name = "tbVon";
            this.tbVon.Size = new System.Drawing.Size(285, 35);
            this.tbVon.TabIndex = 2;
            this.tbVon.Text = "50";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vốn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 695);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox tbLoiNhuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMoiLenh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVonBanDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoTienMoiLenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVonCuoiNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
    }
}

