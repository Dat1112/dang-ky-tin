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
using System.Configuration;
using System.Data.Common;

namespace project
{
    public partial class Form1 : Form
    {
       


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tk = txttaikhoan.Text.Trim();
            string mk = txtmatkhau.Text.Trim();
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                string sql = "Select *From taikhoan Where tendangnhap = '" + txttaikhoan.Text.Trim() + "' and matkhau = '"+ txtmatkhau.Text.Trim() +"' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable tb = new DataTable();
                da.Fill(tb);
                cmd.Dispose();
                if(tb.Rows.Count > 0)
                {
                    Properties.Settings.Default.ten = tb.Rows[0][2].ToString().Trim();
                    Properties.Settings.Default.Save();

                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txttaikhoan.Clear();
                    txtmatkhau.Clear();
                    txttaikhoan.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                con.Close();
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txttaikhoan.Text = Properties.Settings.Default.tkhoan;
            txtmatkhau.Text = Properties.Settings.Default.mkhau;
            if (Properties.Settings.Default.tkhoan != "")
                chkluu.Checked = true;
        }


        private void chkluu_CheckedChanged(object sender, EventArgs e)
        {
            if (txttaikhoan.Text != "" && txtmatkhau.Text != "")
            {
                if (chkluu.Checked)
                {
                    string tk = txttaikhoan.Text.Trim();
                    string mk = txtmatkhau.Text.Trim();
                    Properties.Settings.Default.tkhoan = tk;
                    Properties.Settings.Default.mkhau = mk;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }
    }
}
