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
    public partial class ad_ctrinh : Form
    {
        public ad_ctrinh()
        {
            InitializeComponent();
        }
        private void txttim_Enter(object sender, EventArgs e)
        {

        }
        private void Load_dvg1(string p_cbonganh)
        {
            if (p_cbonganh == "")
            {
                MessageBox.Show("Chọn ngành");
            }else
            {
                DataTable tb = thuvien.bang("Select mon,sotin,hocky from "+p_cbonganh+" ");
                dvg1.DataSource = tb;
                dvg1.Refresh();
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            Load_dvg1(cbonganh.Text.Substring(0,2));
        }

        private void ad_ctrinh_Load(object sender, EventArgs e)
        {

        }

        private void cbohk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dvg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dvg1.CurrentCell.RowIndex;
            txtten.Text = dvg1.Rows[i].Cells[0].Value.ToString();
            txttin.Text = dvg1.Rows[i].Cells[1].Value.ToString();
            txthocky.Text = dvg1.Rows[i].Cells[2].Value.ToString();
        }

        private void btntrangthai_Click(object sender, EventArgs e)
        {
            Load_dvg1(cbonganh.Text.Substring(0, 2));
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string p_cbonganh = cbonganh.Text.Substring(0, 2);
            if (p_cbonganh == "")
            {
                MessageBox.Show("Chọn ngành");
            }
            else
            {
                string a = txtten.Text.Trim();
                string b = txttin.Text.Trim();
                string c = txthocky.Text.Trim();
                if (a == "" || b == "" || c == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else if (thuvien.Checktrungma(a, p_cbonganh, "mon"))
                    MessageBox.Show("Trùng môn");
                else
                {


                    thuvien.thucthi("Insert into " + p_cbonganh + " (mon,sotin,hocky) Values (N'" + a + "'," + b + "," + c + ")");
                    MessageBox.Show("Thêm thành công");
                    Load_dvg1(p_cbonganh);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string p_cbonganh = cbonganh.Text.Substring(0, 2);
            if (p_cbonganh == "")
            {
                MessageBox.Show("Chọn ngành");
            }
            else
            {
                string a = txtten.Text.Trim();
                thuvien.thucthi("Delete from "+p_cbonganh+" where mon = N'"+a+"'");
                MessageBox.Show("Xóa thành công");
                Load_dvg1(p_cbonganh);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string p_cbonganh = cbonganh.Text.Substring(0, 2);
            if (p_cbonganh == "")
            {
                MessageBox.Show("Chọn ngành");
            }
            else
            {
                string a = txtten.Text.Trim();
                string b = txttin.Text.Trim();
                string c = txthocky.Text.Trim();
                if (thuvien.Checktrungma(a, p_cbonganh, "mon"))
                    thuvien.thucthi("update " + p_cbonganh + " set sotin = " + b + ",hocky = " + c + " where mon = N'" + a + "'");
                else MessageBox.Show("Tên học phần thay đổi");
                Load_dvg1(p_cbonganh);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string p_cbonganh = cbonganh.Text.Substring(0, 2);
            if (p_cbonganh == "")
            {
                MessageBox.Show("Chọn ngành");
            }
            else
            {
                string a = txtten.Text.Trim();
                if (p_cbonganh == "")
                {
                    MessageBox.Show("Chọn ngành");
                }
                else
                {
                    DataTable tb = thuvien.bang("Select mon,sotin,hocky from " + p_cbonganh + " where " +
                        "mon like '%"+a+"%' ");
                    dvg1.DataSource = tb;
                    dvg1.Refresh();
                }

            }
        }
    }
}
