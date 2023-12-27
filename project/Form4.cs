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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string nganh = Properties.Settings.Default.tkhoan.Substring(4, 2);
            string sql = "Select ten from nganh where ma = '"+nganh+"'";
            label2.Text = thuvien.bang(sql).Rows[0][0].ToString();          
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            string nganh = Properties.Settings.Default.tkhoan.Substring(4, 2);
            string sql = "Select dki.mon,dki.sotin From dki," + nganh + " Where dki.ten IS NULL and dki.mon = " + nganh + ".mon and dki.malop like '%1%'";
            dvg1.DataSource = thuvien.bang(sql);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string a = txttim.Text.Trim();
            string nganh = Properties.Settings.Default.tkhoan.Substring(4, 2);
            string sql = "Select dki.mon,dki.sotin From dki," + nganh + " Where dki.ten IS NULL and dki.mon = " + nganh + ".mon and dki.malop like '%1%' and ( dki.mon like '%"+a+"%' or dki.sotin  like '%"+a+"%' )";
            dvg1.DataSource = thuvien.bang(sql);
        }
    }
}
