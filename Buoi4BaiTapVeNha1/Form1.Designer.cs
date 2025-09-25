namespace Buoi4BaiTapVeNha1
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
            this.grbSinhVien = new System.Windows.Forms.GroupBox();
            this.cbbChuyenNghanh = new System.Windows.Forms.ComboBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnNu = new System.Windows.Forms.Button();
            this.grbSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSinhVien
            // 
            this.grbSinhVien.Controls.Add(this.cbbChuyenNghanh);
            this.grbSinhVien.Controls.Add(this.txtDTB);
            this.grbSinhVien.Controls.Add(this.rdbNu);
            this.grbSinhVien.Controls.Add(this.rdbNam);
            this.grbSinhVien.Controls.Add(this.txtHoTen);
            this.grbSinhVien.Controls.Add(this.txtMSSV);
            this.grbSinhVien.Controls.Add(this.label3);
            this.grbSinhVien.Controls.Add(this.label2);
            this.grbSinhVien.Controls.Add(this.label1);
            this.grbSinhVien.Controls.Add(this.lblHoTen);
            this.grbSinhVien.Controls.Add(this.lblMSSV);
            this.grbSinhVien.Location = new System.Drawing.Point(21, 41);
            this.grbSinhVien.Name = "grbSinhVien";
            this.grbSinhVien.Size = new System.Drawing.Size(340, 223);
            this.grbSinhVien.TabIndex = 0;
            this.grbSinhVien.TabStop = false;
            this.grbSinhVien.Text = "Thông Tin Sinh Viên";
            // 
            // cbbChuyenNghanh
            // 
            this.cbbChuyenNghanh.FormattingEnabled = true;
            this.cbbChuyenNghanh.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cbbChuyenNghanh.Location = new System.Drawing.Point(130, 146);
            this.cbbChuyenNghanh.Name = "cbbChuyenNghanh";
            this.cbbChuyenNghanh.Size = new System.Drawing.Size(169, 24);
            this.cbbChuyenNghanh.TabIndex = 10;
            this.cbbChuyenNghanh.SelectedIndexChanged += new System.EventHandler(this.cbbChuyenNghanh_SelectedIndexChanged);
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(130, 118);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(68, 22);
            this.txtDTB.TabIndex = 9;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(213, 89);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 8;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(130, 89);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(130, 61);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(169, 22);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(130, 33);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(169, 22);
            this.txtMSSV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyên nghành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm TB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới tính";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(19, 58);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(19, 33);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(85, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã Sinh Viên";
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(111, 270);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(122, 33);
            this.btnThemSua.TabIndex = 1;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(247, 270);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMSSV,
            this.clHoTen,
            this.clGioiTinh,
            this.clDTB,
            this.clKhoa});
            this.dataGridView1.Location = new System.Drawing.Point(386, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 223);
            this.dataGridView1.TabIndex = 3;
            // 
            // clMSSV
            // 
            this.clMSSV.HeaderText = "MSSV";
            this.clMSSV.MinimumWidth = 6;
            this.clMSSV.Name = "clMSSV";
            this.clMSSV.Width = 125;
            // 
            // clHoTen
            // 
            this.clHoTen.HeaderText = "Họ Tên";
            this.clHoTen.MinimumWidth = 6;
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.Width = 125;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.HeaderText = "Giới Tính";
            this.clGioiTinh.MinimumWidth = 6;
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.Width = 125;
            // 
            // clDTB
            // 
            this.clDTB.HeaderText = "Điểm TB";
            this.clDTB.MinimumWidth = 6;
            this.clDTB.Name = "clDTB";
            this.clDTB.Width = 125;
            // 
            // clKhoa
            // 
            this.clKhoa.HeaderText = "Khoa";
            this.clKhoa.MinimumWidth = 6;
            this.clKhoa.Name = "clKhoa";
            this.clKhoa.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng SV Nam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nữ";
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(747, 287);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(75, 23);
            this.btnNam.TabIndex = 6;
            this.btnNam.Text = "0";
            this.btnNam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // btnNu
            // 
            this.btnNu.Location = new System.Drawing.Point(877, 287);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(75, 23);
            this.btnNu.TabIndex = 7;
            this.btnNu.Text = "0";
            this.btnNu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 451);
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.grbSinhVien);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin sinh viên";
            this.grbSinhVien.ResumeLayout(false);
            this.grbSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSinhVien;
        private System.Windows.Forms.Label lblMSSV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.ComboBox cbbChuyenNghanh;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhoa;
    }
}

