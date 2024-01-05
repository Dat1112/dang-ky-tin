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
    public partial class ad_thongbao : Form
    {
        public ad_thongbao()
        {
            InitializeComponent();
        }
        private void Load_dvg1()
        {
            dvg1.DataSource = thuvien.bang("Select *from thongbao");
            dvg1.Refresh();
        }
        private void btnphanhoi_Click(object sender, EventArgs e)
        {
           
            string b = txtnoidung.Text.Trim();
            string c = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");           
            thuvien.thucthi("Insert thongbao values(N'" + b + "','" + c + "')");
            MessageBox.Show("Thông báo thành công");
            Load_dvg1();
        }

        private void ad_thongbao_Load(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = dvg1.CurrentRow.Index;
            string a = dvg1.Rows[i].Cells[0].Value.ToString();
            thuvien.thucthi("Delete from thongbao where news = N'" + a + "' ");
            MessageBox.Show("Xóa thành công");
            Load_dvg1();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string tim = txtnoidung.Text.Trim();
            dvg1.DataSource = thuvien.bang("Select *from thongbao where news like N'%"+tim +"%' or time like '%"+tim+"%'");
            dvg1.Refresh();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int i = dvg1.CurrentRow.Index;
            string a = dvg1.Rows[i].Cells[0].Value.ToString();
            string b= txtnoidung.Text.Trim();
            string c = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            thuvien.thucthi("Update thongbao  set news = N'"+b+"',time = '"+c+"' where news = N'" + a + "' ");
            MessageBox.Show("Sửa thành công");
            Load_dvg1();
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            Load_dvg1();
        }
    }
}
