using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class gopy : Form
    {
        public gopy()
        {
            InitializeComponent();
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            string a = Properties.Settings.Default.tkhoan;
            string b = txtykien.Text;
            thuvien.thucthi("Insert gopy values('"+a+"',N'"+b+"')");
            MessageBox.Show("Cảm ơn bạn");
            Load_dvg1();
        }

        private void Load_dvg1()
        {
            string a = Properties.Settings.Default.tkhoan;
            dvg1.DataSource = thuvien.bang("Select svgopy from gopy where masv = '"+a+"'");
            dvg1.Refresh();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = dvg1.CurrentRow.Index;
            string a = dvg1.Rows[i].Cells[0].Value.ToString();
            string b = Properties.Settings.Default.tkhoan;
            thuvien.thucthi("Delete from gopy where masv = '" + b + "' and svgopy = N'" + a + "' ");
            MessageBox.Show("Xóa thành công");
            Load_dvg1();
        }

        private void gopy_Load(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void dvg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtykien.Text = dvg1.Rows[i].Cells[0].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int i = dvg1.CurrentRow.Index;
            string a = dvg1.Rows[i].Cells[0].Value.ToString();
            string b = Properties.Settings.Default.tkhoan;
            string c = txtykien.Text;
            thuvien.thucthi("update gopy set svgopy = N'" + c + "' where masv = '" + b + "' and svgopy = N'" + a + "'");
            Load_dvg1();
        }
    }
}
