using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Load_dvg1()
        {
            dvg1.DataSource = thuvien.bang("Select *from thongbao");
            dvg1.Refresh();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            Load_dvg1();
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            string tim = txtnoidung.Text.Trim();
            dvg1.DataSource = thuvien.bang("Select *from thongbao where news like N'%" + tim + "%' or time like '%" + tim + "%'");
            dvg1.Refresh();
        }
    }
}
