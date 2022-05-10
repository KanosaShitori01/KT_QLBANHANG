using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasmaControl;
using System.Data.SqlClient;
namespace QL_BENHENG
{
    public partial class Form1 : Form
    {
        SqlConnection conn = TasmaMain.ketnoi(@"DESKTOP-MC\SQLEXPRESS", "QLBH");
        public void activeData()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("KHACH_HANG", conn);
            cb_kh.DataSource = dt;
            cb_kh.DisplayMember = "TenKHG";
            cb_kh.ValueMember = "MaKHG";
            DataTable dt2 = TasmaMain.LietKeDuLieu("NHAN_VIEN", conn);
            cb_nv.DataSource = dt2;
            cb_nv.DisplayMember = "TenNV";
            cb_nv.ValueMember = "MaNV";
            txt_sopx.Text = "PX" + Convert.ToInt32(TasmaMain.LietKeDuLieu("PHIEU_XUAT", conn).Rows.Count + 1);
            activeDataGV();
        }
        public void activeDataGV()
        {
            dataGV1.DataSource = TasmaMain.LietKeDuLieu("HANG_HOA", conn);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            activeData();
        }
        public void activeTC()
        {
            double tienhang = 0;
            double thue = 0;
            double chietkhau = 0;
            double tongcong = 0;
            for(int i = 0; i < dataGV2.Rows.Count - 1; i++)
            {
                tienhang += Convert.ToDouble(dataGV2.Rows[i].Cells["ThanhTien"].Value);
            }
            thue = (Convert.ToDouble(nup_thue.Value) / 100) * tienhang;
            chietkhau = (Convert.ToDouble(nup_chietkhau.Value) / 100) * tienhang;
            tongcong = tienhang + thue - chietkhau;
            txt_tienhang.Text = tienhang.ToString();
            txt_thue.Text = thue.ToString();
            txt_chietkhau.Text = chietkhau.ToString();
            txt_tongcong.Text = tongcong.ToString();
        }
        public void activeAddGV()
        {
            if (nup_sl.Value > 0)
            {
                DataGridViewCellCollection DGV1 = dataGV1.CurrentRow.Cells;
                int thanhtien = Convert.ToInt32(nup_sl.Value) *
                    Convert.ToInt32(DGV1["DonGiaHT"].Value);
                dataGV2.Rows.Add(DGV1["MaHang"].Value, DGV1["TenHang"].Value,
                    nup_sl.Value, DGV1["DongiaHT"].Value, thanhtien);
                MessageBox.Show("Đã Thêm " + DGV1["TenHang"].Value);
                activeTC();
            }
            else MessageBox.Show("Số lượng phải lớn hơn 0");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            activeAddGV();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("SoPX", txt_sopx.Text);
            dl.Add("NgayPX", TasmaMain.StrangeDate(dtp_ngay.Text));
            dl.Add("MaKHG", cb_kh.SelectedValue);
            dl.Add("SoTienPhaiTra", txt_tongcong.Text);
            dl.Add("SoTienDaTra", 0);
            if (TasmaMain.ThemDuLieu("PHIEU_XUAT", dl, conn))
            {
                MessageBox.Show("Đã Lưu Thành Công Phiếu Xuất " + txt_sopx.Text);
                for (int i = 0; i < dataGV2.Rows.Count - 1; i++)
                {
                    DataGridViewCellCollection DGV = dataGV2.Rows[i].Cells;
                    Dictionary<string, object> dlIn = new Dictionary<string, object>();
                    dlIn.Add("SoPX", txt_sopx.Text);
                    dlIn.Add("MaHH", DGV["MaHang_M"].Value);
                    dlIn.Add("SoLuong", nup_sl.Value);
                    dlIn.Add("DonGia", DGV["GiaBan"].Value);
                    TasmaMain.ThemDuLieu("CTPX", dlIn, conn);
                }
            }
            else MessageBox.Show("Có lỗi xảy ra trong quá trình lưu");
        }

        private void nup_thue_ValueChanged(object sender, EventArgs e)
        {
            activeTC();
        }

        private void nup_chietkhau_ValueChanged(object sender, EventArgs e)
        {
            activeTC();
        }

        private void txt_sopx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            activeData();
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void btn_xemttp_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
        }
    }
}
