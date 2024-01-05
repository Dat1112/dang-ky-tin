using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace project
{
    internal class thuvien
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public static DataTable bang (string sql)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            return tb;
        }
        public static void thucthi (string sql)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public static bool Checktrungma(string p_makt, string p_tenbang, string p_tencot)
        {
            //B1:ket noi db
            if (con.State == ConnectionState.Closed)
                con.Open();
            //B2:tao doi tuong command de thuc hien kiem tra
            string sql = "Select count(*)From " + p_tenbang + " where " + p_tencot + "=N'" + p_makt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            if (kq > 0) return true;
            else return false;

        }
        public static string tim(string ma,string tim)
        {
            string sql = "Select "+tim+" from taikhoan where tendangnhap = '"+ma+"'";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            string k = tb.Rows[0][0].ToString();
            return k;
        }

    }
}
