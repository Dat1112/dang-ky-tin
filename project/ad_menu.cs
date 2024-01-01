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
    public partial class ad_menu : Form
    {
        bool isthoat = true;
        
        public ad_menu()
        {
            InitializeComponent();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            isthoat = false;
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void ad_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)
                Application.Exit();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btncn_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = btncn.Text;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string nganh = cbonganh.Text.Substring(0, 2);
            string khoa = cbokhoa.Text;
            string hk = cbohk.Text;          
            thuvien.thucthi("update "+nganh+" set ["+khoa+"] = "+hk+"");
            MessageBox.Show("Cập nhật thành công");
            DataTable tb = thuvien.bang("Select dki.mon,dki.malop,dki.sotin,dki.sv,dki.svmax From dki," + nganh + " " +
                "Where dki.ten IS NULL and dki.mon = " + nganh + ".mon and " + nganh + ".[" + khoa + "]=" + nganh + ".hocky");
            dvg1.DataSource = tb;
            dvg1.Refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Load_dvg1()
        {
            DataTable tb = thuvien.bang("Select mon,malop,sotin,sv,svmax From dki");
            dvg1.DataSource = tb;
            dvg1.Refresh();
        }

        private void ad_menu_Load(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void btntrangthai_Click(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void dvg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dvg1.CurrentCell.RowIndex;
            txtten.Text = dvg1.Rows[i].Cells[0].Value.ToString();
            txtma.Text = dvg1.Rows[i].Cells[1].Value.ToString();
            txttin.Text = dvg1.Rows[i].Cells[2].Value.ToString();
            txtsiso.Text = dvg1.Rows[i].Cells[3].Value.ToString();
            txtlich.Text = dvg1.Rows[i].Cells[4].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text.Trim();
            string ma = txtma.Text.Trim();
            string tin = txttin.Text.Trim();
            string siso = txtsiso.Text.Trim();
            string lich= txtlich.Text.Trim();
            if (ten == "" || ma == "" || tin == "" || siso == "" || lich == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (thuvien.Checktrungma(ma, "dki", "malop"))
                MessageBox.Show("Trùng mã lớp");
            else
            {
               
                thuvien.thucthi("Insert into dki(malop,mon,sv,svmax,sotin) values ('" + ma + "',N'" + ten + "'," + siso + ",N'" + lich + "'," + tin + ")");
                MessageBox.Show("thêm thành công");
                Load_dvg1();
                txtten.Clear();txtma.Clear();txttin.Clear();txtsiso.Clear();txtlich.Clear();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text.Trim();
            thuvien.thucthi("Delete dki where malop = '" + ma + "'");
            Load_dvg1();
            MessageBox.Show("Xóa thành công");
            txtten.Clear(); txtma.Clear(); txttin.Clear(); txtsiso.Clear(); txtlich.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text.Trim();
            string ma = txtma.Text.Trim();
            string tin = txttin.Text.Trim();
            string siso = txtsiso.Text.Trim();
            string lich = txtlich.Text.Trim();
            if (thuvien.Checktrungma(ma, "dki", "malop"))
            {
                thuvien.thucthi("update dki set mon=N'" + ten + "',sv=" + siso + ",svmax=N'" + lich + "',sotin=" + tin + "where malop = '"+ma+"'");
            } else MessageBox.Show("Mã thay đổi");
            Load_dvg1();
            MessageBox.Show("sửa thành công");
            txtten.Clear(); txtma.Clear(); txttin.Clear(); txtsiso.Clear(); txtlich.Clear();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tim = txttimm.Text.Trim();
            DataTable tb = thuvien.bang("Select mon,malop,sotin,sv,svmax From dki Where ten IS NULL and (mon like '%" + tim + "%' or malop like '%" + tim + "%' or sotin like '%" + tim + "%' or sv like '%" + tim + "%' or  svmax like '%" + tim + "%')");
            dvg1.DataSource = tb;
            dvg1.Refresh();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string nganh = cbonganh.Text.Substring(0, 2);
            string khoa = cbokhoa.Text;
            string hk = cbohk.Text;
            DataTable tb = thuvien.bang("Select dki.mon,dki.malop,dki.sotin,dki.sv,dki.svmax From dki," + nganh + " " +
                "Where dki.ten IS NULL and dki.mon = " + nganh + ".mon and " + nganh + ".hocky = "+hk+"");
            dvg1.DataSource = tb;
            dvg1.Refresh();
        }

        private void btnctrinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ad_ctrinh());
            label1.Text = btnctrinh.Text;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
