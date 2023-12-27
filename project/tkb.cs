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
    public partial class tkb : Form
    {
        public tkb()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Load_dvg1()
        {
            dvg1.Rows.Add(); dvg1.Rows.Add(); dvg1.Rows.Add();
            string x = "Tiết 1,2,3";string y = "Tiết 4,5,6";string z = "Tiết 7,8,9";string c = "Tiết 10,11,12";
            dvg1.Rows[0].Cells[0].Value =x;
            dvg1.Rows[1].Cells[0].Value =y ;
            dvg1.Rows[2].Cells[0].Value =z ;
            dvg1.Rows[3].Cells[0].Value =c ;
            string a = Properties.Settings.Default.tkhoan;
           // dvg1.Columns["Thứ Hai"].DataSource = thuvien.bang("Select malop From dki Where ten = N'" + a + "' and svmax like '%" + "T2" + "%' and svmax like N'%" + x + "%'");
           // dvg1.Columns["Thứ Hai"].Da
        }

        private void tkb_Load(object sender, EventArgs e)
        {
            Load_dvg1();
        }
    }
}
