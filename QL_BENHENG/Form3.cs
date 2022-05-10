using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BENHENG
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBHDataSet1.CTPX' table. You can move, or remove it, as needed.
            this.CTPXTableAdapter.Fill(this.QLBHDataSet1.CTPX);

            this.reportViewer1.RefreshReport();
        }
    }
}
