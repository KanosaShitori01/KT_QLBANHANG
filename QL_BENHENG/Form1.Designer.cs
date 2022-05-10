
namespace QL_BENHENG
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
            this.cb_khohang = new System.Windows.Forms.ComboBox();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.dataGV1 = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addkh = new System.Windows.Forms.Button();
            this.txt_sopx = new System.Windows.Forms.TextBox();
            this.nup_thue = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_diengiai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_kh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soctg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_themsp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_tongcong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_chietkhau = new System.Windows.Forms.TextBox();
            this.nup_chietkhau = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_thue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tienhang = new System.Windows.Forms.TextBox();
            this.nup_sl = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGV2 = new System.Windows.Forms.DataGridView();
            this.MaHang_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xemttp = new System.Windows.Forms.Button();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_thue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_chietkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_sl)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_khohang
            // 
            this.cb_khohang.FormattingEnabled = true;
            this.cb_khohang.Location = new System.Drawing.Point(93, 49);
            this.cb_khohang.Name = "cb_khohang";
            this.cb_khohang.Size = new System.Drawing.Size(100, 21);
            this.cb_khohang.TabIndex = 1;
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngay.Location = new System.Drawing.Point(298, 23);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(135, 20);
            this.dtp_ngay.TabIndex = 2;
            // 
            // dataGV1
            // 
            this.dataGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.DonGiaHT,
            this.SoLuong});
            this.dataGV1.Location = new System.Drawing.Point(211, 223);
            this.dataGV1.Name = "dataGV1";
            this.dataGV1.Size = new System.Drawing.Size(546, 99);
            this.dataGV1.TabIndex = 3;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHH";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHH";
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.Name = "TenHang";
            // 
            // DonGiaHT
            // 
            this.DonGiaHT.DataPropertyName = "DonGiaHienTai";
            this.DonGiaHT.HeaderText = "Đơn Giá Hiện Tại";
            this.DonGiaHT.Name = "DonGiaHT";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // btn_addkh
            // 
            this.btn_addkh.Location = new System.Drawing.Point(370, 76);
            this.btn_addkh.Name = "btn_addkh";
            this.btn_addkh.Size = new System.Drawing.Size(63, 23);
            this.btn_addkh.TabIndex = 4;
            this.btn_addkh.Text = "+";
            this.btn_addkh.UseVisualStyleBackColor = true;
            // 
            // txt_sopx
            // 
            this.txt_sopx.Enabled = false;
            this.txt_sopx.Location = new System.Drawing.Point(93, 23);
            this.txt_sopx.Name = "txt_sopx";
            this.txt_sopx.Size = new System.Drawing.Size(100, 20);
            this.txt_sopx.TabIndex = 5;
            this.txt_sopx.TextChanged += new System.EventHandler(this.txt_sopx_TextChanged);
            // 
            // nup_thue
            // 
            this.nup_thue.Location = new System.Drawing.Point(98, 53);
            this.nup_thue.Name = "nup_thue";
            this.nup_thue.Size = new System.Drawing.Size(53, 20);
            this.nup_thue.TabIndex = 6;
            this.nup_thue.ValueChanged += new System.EventHandler(this.nup_thue_ValueChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tìm theo mã hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Tìm ký tự bắt đầu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_nv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_diengiai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_kh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_addkh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_soctg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sopx);
            this.groupBox1.Controls.Add(this.cb_khohang);
            this.groupBox1.Controls.Add(this.dtp_ngay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất kho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nhân Viên";
            // 
            // cb_nv
            // 
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(332, 129);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(100, 21);
            this.cb_nv.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ghi chú";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(93, 129);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(100, 20);
            this.txt_ghichu.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diễn giải";
            // 
            // txt_diengiai
            // 
            this.txt_diengiai.Location = new System.Drawing.Point(93, 103);
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.Size = new System.Drawing.Size(340, 20);
            this.txt_diengiai.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Khách Hàng*";
            // 
            // cb_kh
            // 
            this.cb_kh.FormattingEnabled = true;
            this.cb_kh.Location = new System.Drawing.Point(93, 76);
            this.cb_kh.Name = "cb_kh";
            this.cb_kh.Size = new System.Drawing.Size(271, 21);
            this.cb_kh.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số chứng từ gốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kho Hàng";
            // 
            // txt_soctg
            // 
            this.txt_soctg.Location = new System.Drawing.Point(298, 49);
            this.txt_soctg.Name = "txt_soctg";
            this.txt_soctg.Size = new System.Drawing.Size(135, 20);
            this.txt_soctg.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số PX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tìm kiếm : ";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(81, 186);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(247, 20);
            this.txt_timkiem.TabIndex = 19;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(334, 184);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(63, 23);
            this.btn_tim.TabIndex = 18;
            this.btn_tim.Text = "Tìm ";
            this.btn_tim.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số lượng:";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(578, 184);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(63, 23);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_themsp
            // 
            this.btn_themsp.Location = new System.Drawing.Point(647, 184);
            this.btn_themsp.Name = "btn_themsp";
            this.btn_themsp.Size = new System.Drawing.Size(110, 23);
            this.btn_themsp.TabIndex = 21;
            this.btn_themsp.Text = "Thêm sản phẩm";
            this.btn_themsp.UseVisualStyleBackColor = true;
            this.btn_themsp.Click += new System.EventHandler(this.btn_themsp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_tongcong);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_chietkhau);
            this.groupBox2.Controls.Add(this.nup_chietkhau);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_thue);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_tienhang);
            this.groupBox2.Controls.Add(this.nup_thue);
            this.groupBox2.Location = new System.Drawing.Point(480, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 166);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng cộng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Tổng cộng :";
            // 
            // txt_tongcong
            // 
            this.txt_tongcong.Enabled = false;
            this.txt_tongcong.Location = new System.Drawing.Point(98, 129);
            this.txt_tongcong.Name = "txt_tongcong";
            this.txt_tongcong.Size = new System.Drawing.Size(153, 20);
            this.txt_tongcong.TabIndex = 26;
            this.txt_tongcong.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Chiết khấu :";
            // 
            // txt_chietkhau
            // 
            this.txt_chietkhau.Enabled = false;
            this.txt_chietkhau.Location = new System.Drawing.Point(153, 79);
            this.txt_chietkhau.Name = "txt_chietkhau";
            this.txt_chietkhau.Size = new System.Drawing.Size(98, 20);
            this.txt_chietkhau.TabIndex = 24;
            this.txt_chietkhau.Text = "0";
            // 
            // nup_chietkhau
            // 
            this.nup_chietkhau.Location = new System.Drawing.Point(98, 80);
            this.nup_chietkhau.Name = "nup_chietkhau";
            this.nup_chietkhau.Size = new System.Drawing.Size(53, 20);
            this.nup_chietkhau.TabIndex = 22;
            this.nup_chietkhau.ValueChanged += new System.EventHandler(this.nup_chietkhau_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Thuế :";
            // 
            // txt_thue
            // 
            this.txt_thue.Enabled = false;
            this.txt_thue.Location = new System.Drawing.Point(153, 52);
            this.txt_thue.Name = "txt_thue";
            this.txt_thue.Size = new System.Drawing.Size(98, 20);
            this.txt_thue.TabIndex = 21;
            this.txt_thue.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tiền hàng :";
            // 
            // txt_tienhang
            // 
            this.txt_tienhang.Enabled = false;
            this.txt_tienhang.Location = new System.Drawing.Point(98, 23);
            this.txt_tienhang.Name = "txt_tienhang";
            this.txt_tienhang.Size = new System.Drawing.Size(153, 20);
            this.txt_tienhang.TabIndex = 19;
            this.txt_tienhang.Text = "0";
            // 
            // nup_sl
            // 
            this.nup_sl.Location = new System.Drawing.Point(513, 187);
            this.nup_sl.Name = "nup_sl";
            this.nup_sl.Size = new System.Drawing.Size(53, 20);
            this.nup_sl.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(17, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 105);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn tìm kiếm";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tìm theo tên hàng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGV2
            // 
            this.dataGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang_M,
            this.TenHang_M,
            this.SoLuong_M,
            this.GiaBan,
            this.ThanhTien});
            this.dataGV2.Location = new System.Drawing.Point(17, 328);
            this.dataGV2.Name = "dataGV2";
            this.dataGV2.Size = new System.Drawing.Size(740, 110);
            this.dataGV2.TabIndex = 24;
            // 
            // MaHang_M
            // 
            this.MaHang_M.HeaderText = "Mã Hàng";
            this.MaHang_M.Name = "MaHang_M";
            // 
            // TenHang_M
            // 
            this.TenHang_M.HeaderText = "Tên Hàng";
            this.TenHang_M.Name = "TenHang_M";
            // 
            // SoLuong_M
            // 
            this.SoLuong_M.HeaderText = "Số Lượng";
            this.SoLuong_M.Name = "SoLuong_M";
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // btn_xemttp
            // 
            this.btn_xemttp.Location = new System.Drawing.Point(438, 444);
            this.btn_xemttp.Name = "btn_xemttp";
            this.btn_xemttp.Size = new System.Drawing.Size(110, 23);
            this.btn_xemttp.TabIndex = 25;
            this.btn_xemttp.Text = "Xem TT phiếu";
            this.btn_xemttp.UseVisualStyleBackColor = true;
            this.btn_xemttp.Click += new System.EventHandler(this.btn_xemttp_Click);
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Location = new System.Drawing.Point(554, 444);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(110, 23);
            this.btn_taomoi.TabIndex = 26;
            this.btn_taomoi.Text = "Tạo Mới";
            this.btn_taomoi.UseVisualStyleBackColor = true;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(670, 444);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(87, 23);
            this.btn_luu.TabIndex = 27;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 473);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_taomoi);
            this.Controls.Add(this.btn_xemttp);
            this.Controls.Add(this.dataGV2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nup_sl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_themsp);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dataGV1);
            this.Name = "Form1";
            this.Text = "Phiếu Xuất";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_thue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_chietkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_sl)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_khohang;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
        private System.Windows.Forms.DataGridView dataGV1;
        private System.Windows.Forms.Button btn_addkh;
        private System.Windows.Forms.TextBox txt_sopx;
        private System.Windows.Forms.NumericUpDown nup_thue;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soctg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_kh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_diengiai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_nv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_themsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tienhang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_thue;
        private System.Windows.Forms.NumericUpDown nup_sl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_chietkhau;
        private System.Windows.Forms.NumericUpDown nup_chietkhau;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_tongcong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGV2;
        private System.Windows.Forms.Button btn_xemttp;
        private System.Windows.Forms.Button btn_taomoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}

