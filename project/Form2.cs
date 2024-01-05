using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace project
{
    public partial class Form2 : Form
    {
        bool isthoat = true;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public Form2()
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

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isthoat)
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
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
       

        private void btndki_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
            label1.Text = btndki.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
            label1.Text = button2.Text;
        }

        private void btncanhan_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "ĐÃ ĐĂNG KÝ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
            label1.Text = button3.Text;
        }

        private void Load_dvg1()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string a = Properties.Settings.Default.tkhoan;
            string sql = "Select mon,malop,sotin,sv,svmax From dki Where ten = N'"+a+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dvg1.DataSource = tb;
            dvg1.Refresh();
        }





        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Properties.Settings.Default.ten;
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        
        private void btnhuy_Click(object sender, EventArgs e)
        {
            int i = dvg1.CurrentRow.Index;
            string tksv = Properties.Settings.Default.tkhoan; 
            string ma_p = dvg1.Rows[i].Cells[1].Value.ToString();
            string syso_p = (int.Parse(dvg1.Rows[i].Cells[3].Value.ToString()) - 1).ToString();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "Delete dki Where malop = '"+ma_p+"' and ten = N'"+tksv+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            string SQL = "Update dki set sv = '" + syso_p + "' where malop = '" + ma_p + "' and ten IS NULL";
            SqlCommand Cmd = new SqlCommand(SQL, con);
            Cmd.ExecuteNonQuery();
            Cmd.Dispose();
            con.Close();
            MessageBox.Show("Huy dang ky thanh cong");
            Load_dvg1();            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string a = Properties.Settings.Default.ten;
            if (con.State == ConnectionState.Closed)
                con.Open();
            string tim = txttim.Text.Trim();
            string sql = "Select mon,malop,sotin,sv,svmax From dki Where ten = N'"+a+"' and (mon like '%" + tim + "%' or malop like '%" + tim + "%' or sotin like '%" + tim + "%' or sv like '%" + tim + "%' or  svmax like '%" + tim + "%')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dvg1.DataSource = tb;
            dvg1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new gopy());
            label1.Text = button1.Text;
        }

        private void btntkb_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tkb());
            label1.Text = btntkb.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new canhcao());
            label1.Text = button5.Text;
        }
    }
}
