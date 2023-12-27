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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public Form3()
        {
            InitializeComponent();
        }
        private void Load_dvg1()
        {
            if(con.State == ConnectionState.Closed)
                con.Open();
            string nganh = Properties.Settings.Default.tkhoan.Substring(4, 2);
            string a = Properties.Settings.Default.tkhoan;          
            string sql = "Select dki.mon,dki.malop,dki.sotin,dki.sv,dki.svmax From dki,"+nganh+" Where dki.ten IS NULL and dki.mon = "+nganh+".mon";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            dvg1.DataSource = tb;        
            string SQL = "Select dki.malop,dki.mon,dki.svmax From dki Where dki.ten = N'"+a+"' ";
            SqlCommand Cmd = new SqlCommand(SQL, con);
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            DataTable Tb = new DataTable();
            Da.Fill(Tb);            
            DataTable TB = new DataTable();
            TB = thuvien.bang("Select ketqua.mon,ketqua.diem from ketqua,dki where ketqua.ma='" + a + "' and dki.mon=ketqua.mon");
            for(int i=0; i < tb.Rows.Count; i++)
            {
                if(int.Parse(tb.Rows[i][3].ToString()) == 50)
                    dvg1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;

                for (int j = 0; j < Tb.Rows.Count; j++)
                {
                    if (tb.Rows[i][1].ToString() == Tb.Rows[j][0].ToString() || tb.Rows[i][0].ToString() == Tb.Rows[j][1].ToString() || tb.Rows[i][4].ToString() == Tb.Rows[j][2].ToString())                
                    {
                        dvg1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;                           
                    }                    
                }

                for (int k = 0; k < TB.Rows.Count; k++)
                {
                    if (tb.Rows[i][0].ToString() == TB.Rows[k][0].ToString() && float.Parse(TB.Rows[k][1].ToString()) > 3)
                        dvg1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }

            }
            Cmd.Dispose();
            dvg1.Refresh();
            con.Close();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            int a = dvg1.CurrentRow.Index;
            if (dvg1.Rows[a].DefaultCellStyle.BackColor == Color.Gray)
            {
                MessageBox.Show("khong the dang ky lop nay");
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string tksv = Properties.Settings.Default.tkhoan;
                string mon_p = dvg1.Rows[a].Cells[0].Value.ToString();
                string ma_p = dvg1.Rows[a].Cells[1].Value.ToString();
                string tin_p = dvg1.Rows[a].Cells[2].Value.ToString();
                string syso_p = (int.Parse(dvg1.Rows[a].Cells[3].Value.ToString()) + 1).ToString();
                string syso_p1 = dvg1.Rows[a].Cells[3].Value.ToString();
                string max_p = dvg1.Rows[a].Cells[4].Value.ToString();
                string sql = "Insert dki Values('" + ma_p + "',N'" + mon_p + "','" + syso_p1 + "',N'" + max_p + "',N'" + tksv + "','" + tin_p + "','')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                string SQL = "Update dki set sv = '" + syso_p + "' where malop = '"+ma_p+"'";
                SqlCommand Cmd = new SqlCommand(SQL, con);
                Cmd.ExecuteNonQuery();
                Cmd.Dispose();
                con.Close();
                MessageBox.Show("dang ky thanh cong");
                Load_dvg1();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
       //     Load_dvg1();
         //   DialogResult dl = MessageBox.Show("Đăng ký trước ngày 1/1/2024","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
           // if(dl == DialogResult.OK)
          //  {
            //    Load_dvg1();
     //       }
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void btntrangthai_Click(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string a = Properties.Settings.Default.tkhoan;
            if(con.State == ConnectionState.Closed)           
                con.Open();           
            string tim = txttim.Text.Trim();
            string sql = "Select mon,malop,sotin,sv,svmax From dki Where ten IS NULL and (mon like '%"+tim+ "%' or malop like '%"+tim+ "%' or sotin like '%"+tim+ "%' or sv like '%"+tim+ "%' or  svmax like '%"+tim+"%')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();        
            dvg1.DataSource = tb;
            string SQL = "Select malop,mon,svmax From dki Where ten = N'" + a + "'";
            SqlCommand Cmd = new SqlCommand(SQL, con);
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            DataTable Tb = new DataTable();
            Da.Fill(Tb);
            DataTable TB = new DataTable();
            TB = thuvien.bang("Select ketqua.mon,ketqua.diem from ketqua,dki where ketqua.ma='" + a + "' and dki.mon=ketqua.mon");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (int.Parse(tb.Rows[i][3].ToString()) == 50)
                    dvg1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                for (int j = 0; j < Tb.Rows.Count; j++)
                {
                    if (tb.Rows[i][1].ToString()==Tb.Rows[j][0].ToString() || tb.Rows[i][0].ToString()==Tb.Rows[j][1].ToString() || tb.Rows[i][4].ToString() == Tb.Rows[j][2].ToString())
                    {
                        dvg1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
                for (int k = 0; k < TB.Rows.Count; k++)
                {
                    if (tb.Rows[i][0].ToString() == TB.Rows[k][0].ToString() && float.Parse(TB.Rows[k][1].ToString()) > 3)
                        dvg1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
            }
            Cmd.Dispose();
            dvg1.Refresh();
            con.Close();
        }
    }



}

