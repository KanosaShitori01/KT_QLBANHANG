
namespace QL_BENHENG
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahh = new System.Windows.Forms.TextBox();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_tenhh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new QL_BENHENG.QLBHDataSet();
            this.hANG_HOATableAdapter = new QL_BENHENG.QLBHDataSetTableAdapters.HANG_HOATableAdapter();
            this.maHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaHienTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tenhh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mahh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Location = new System.Drawing.Point(284, 26);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(75, 31);
            this.btn_taomoi.TabIndex = 0;
            this.btn_taomoi.Text = "Tạo Mới";
            this.btn_taomoi.UseVisualStyleBackColor = true;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hàng Hóa:";
            // 
            // txt_mahh
            // 
            this.txt_mahh.Enabled = false;
            this.txt_mahh.Location = new System.Drawing.Point(110, 21);
            this.txt_mahh.Name = "txt_mahh";
            this.txt_mahh.Size = new System.Drawing.Size(119, 20);
            this.txt_mahh.TabIndex = 2;
            // 
            // dataGV
            // 
            this.dataGV.AutoGenerateColumns = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHHDataGridViewTextBoxColumn,
            this.tenHHDataGridViewTextBoxColumn,
            this.donGiaHienTaiDataGridViewTextBoxColumn});
            this.dataGV.DataSource = this.hANGHOABindingSource;
            this.dataGV.Location = new System.Drawing.Point(12, 141);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(361, 182);
            this.dataGV.TabIndex = 3;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(284, 65);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 31);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_tenhh
            // 
            this.txt_tenhh.Location = new System.Drawing.Point(110, 53);
            this.txt_tenhh.Name = "txt_tenhh";
            this.txt_tenhh.Size = new System.Drawing.Size(119, 20);
            this.txt_tenhh.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Hàng Hóa:";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(110, 88);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(119, 20);
            this.txt_dongia.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn Giá:";
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANG_HOA";
            this.hANGHOABindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hANG_HOATableAdapter
            // 
            this.hANG_HOATableAdapter.ClearBeforeFill = true;
            // 
            // maHHDataGridViewTextBoxColumn
            // 
            this.maHHDataGridViewTextBoxColumn.DataPropertyName = "MaHH";
            this.maHHDataGridViewTextBoxColumn.HeaderText = "Mã HH";
            this.maHHDataGridViewTextBoxColumn.Name = "maHHDataGridViewTextBoxColumn";
            // 
            // tenHHDataGridViewTextBoxColumn
            // 
            this.tenHHDataGridViewTextBoxColumn.DataPropertyName = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.HeaderText = "Tên HH";
            this.tenHHDataGridViewTextBoxColumn.Name = "tenHHDataGridViewTextBoxColumn";
            // 
            // donGiaHienTaiDataGridViewTextBoxColumn
            // 
            this.donGiaHienTaiDataGridViewTextBoxColumn.DataPropertyName = "DonGiaHienTai";
            this.donGiaHienTaiDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.donGiaHienTaiDataGridViewTextBoxColumn.Name = "donGiaHienTaiDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 339);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_taomoi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.TextBox txt_mahh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_taomoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_tenhh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label3;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private QLBHDataSetTableAdapters.HANG_HOATableAdapter hANG_HOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaHienTaiDataGridViewTextBoxColumn;
    }
}