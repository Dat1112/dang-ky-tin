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

        private void Loadtext()
        {
            string a = Properties.Settings.Default.tkhoan;
            txtten.Text = thuvien.tim(a, "ten");
            txtquequan.Text = thuvien.tim(a, "quequan");
            txtdonvi.Text = thuvien.tim(a, "donvi");
            txtchucvu.Text = thuvien.tim(a, "chucvu");
            cbogt.SelectedItem = thuvien.tim(a, "gioitinh");
            dtmngaysinh.Text = thuvien.tim(a, "ngaysinh");
            label12.Text = thuvien.tim(a, "tendangnhap");
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            string a = Properties.Settings.Default.tkhoan;
            string nganh = Properties.Settings.Default.tkhoan.Substring(4, 2);
            string sql = "Select ten from nganh where ma = '"+nganh+"'";
            label2.Text = thuvien.bang(sql).Rows[0][0].ToString();
            Loadtext();
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            label1.Text = "KẾT QUẢ HỌC TẬP";
            string ma = Properties.Settings.Default.tkhoan;
            string nganh = Properties.Settings.Default.tkhoan.Substring(4, 2);
            string sql = "Select "+nganh+".mon,"+nganh+".sotin ,ketqua.diem, "+nganh+".hocky from "+nganh+" " +
                " JOIN ketqua ON  ketqua.mon = "+nganh+".mon" +
                " where ketqua.ma ='"+ma+"'";
            dvg1.DataSource = thuvien.bang(sql);
            for(int i = 0; i < thuvien.bang(sql).Rows.Count; i++)
            {
                if (float.Parse(thuvien.bang(sql).Rows[i][2].ToString()) < 3)
                    dvg1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
            }
           
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            label1.Text = "CHƯƠNG TRÌNH HỌC";
            string nganh = Properties.Settings.Default.tkhoan.Substring(4, 2);
            string sql = "Select mon,sotin,hocky from "+nganh+"";
            dvg1.DataSource = thuvien.bang(sql);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string tk = Properties.Settings.Default.tkhoan;
            string ten = txtten.Text.Trim();
            string ns = dtmngaysinh.Text.Trim();
            string gt = cbogt.Text.Trim();
            string que = txtquequan.Text.Trim();
            string dvi = txtdonvi.Text.Trim();
            string cvu = txtchucvu.Text.Trim();
            thuvien.thucthi("Update taikhoan set ten =N'"+ten+"',ngaysinh ='"+ns+"',gioitinh = '"+gt+"'" +
                " ,quequan = N'"+que+"', donvi = N'"+dvi+"',chucvu = N'"+cvu+"' where tendangnhap = '"+tk+"'");
            MessageBox.Show("Lưu thành công");
            Loadtext();
        }

        private void btndoi_Click(object sender, EventArgs e)
        {
            string tk = Properties.Settings.Default.tkhoan;
            if (txtcu.Text == "" || txtmoi.Text == "")
            {
                MessageBox.Show("Thao tác thất bại");
            }
            else if (txtcu.Text == thuvien.tim(tk,"matkhau"))
            {
                Properties.Settings.Default.mkhau = txtmoi.Text;
                thuvien.thucthi("update taikhoan set matkhau = N'" + txtmoi.Text + "' where tendangnhap = '" + tk + "'");
                MessageBox.Show("Đổi thành công");
            }
            else MessageBox.Show("Sai mật khẩu");
        }
    }
}
