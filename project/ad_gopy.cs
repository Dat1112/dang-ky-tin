using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class ad_gopy : Form
    {
        public ad_gopy()
        {
            InitializeComponent();
        }

        private void Load_dvg1()
        {
            dvg1.DataSource = thuvien.bang("Select *from gopy");
            dvg1.Refresh();
        }
        private void ad_gopy_Load(object sender, EventArgs e)
        {
            Load_dvg1 ();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string tim = txttim.Text.Trim();
            dvg1.DataSource = thuvien.bang("Select *from gopy where masv like '%"+tim +"%' or svgopy like N'%"+tim+"%'");
            dvg1.Refresh();
        }

        private void btnphanhoi_Click(object sender, EventArgs e)
        {
            string c = txtphanhoi.Text.Trim();
            int i = dvg1.CurrentRow.Index;
            string a = dvg1.Rows[i].Cells[1].Value.ToString();
            string b = Properties.Settings.Default.tkhoan;
            thuvien.thucthi("update gopy set phanhoi = N'"+c+"' where svgopy = N'"+a+"'");
            Load_dvg1();
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            Load_dvg1();
        }
    }
}
