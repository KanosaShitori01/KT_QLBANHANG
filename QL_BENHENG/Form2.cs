using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TasmaControl;
namespace QL_BENHENG
{
    public partial class Form2 : Form
    {
        SqlConnection conn = TasmaMain.ketnoi(@"DESKTOP-MC\SQLEXPRESS", "QLBH");
        public Form2()
        {
            InitializeComponent();
        }
        public void activeGV()
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.HANG_HOA' table. You can move, or remove it, as needed.
            this.hANG_HOATableAdapter.Fill(this.qLBHDataSet.HANG_HOA);
            txt_mahh.Text = "HH" + Convert.ToInt32(TasmaMain.LietKeDuLieu("HANG_HOA", conn).
                Rows.Count + 1);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            activeGV();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("MaHH", txt_mahh.Text);
            dl.Add("TenHH", txt_tenhh.Text);
            dl.Add("DonGiaHienTai", txt_dongia.Text);
            dl.Add("SoLuong", 100);
            if (TasmaMain.ThemDuLieu("HANG_HOA", dl, conn))
            {
                MessageBox.Show("Thêm Thành Công");
                activeGV();
            }
            else MessageBox.Show("Thêm Thất Bại");
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            activeGV();
            txt_tenhh.Text = "";
            txt_dongia.Text = "";
        }
    }
}
