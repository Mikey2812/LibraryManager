using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Library\CS464_E_INDIVIDUAL_PROJECT\CS464_E_INDIVIDUAL_PROJECT\Data_Library.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }

        public DataTable LoadData(string sqlData)
        {
            da = new SqlDataAdapter(sqlData, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet LoadDataSet(string sqlData)
        {
            //SqlDataAdapter da = new SqlDataAdapter(sqlData, conn);
            DataSet ds = new DataSet();
            //da.Fill(ds, "SINHVIEN");
            return ds;
        }
        public DataTable UpdateGrid()
        {
            SqlCommandBuilder SCB = new SqlCommandBuilder(da);
            da.Update(dt);
            return dt;
        }

        public void Nonquery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            if (ketqua >= 1) MessageBox.Show("Thành công");
            else
            {
                MessageBox.Show("Thất bại");
            }
            conn.Close();
        }
        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
        public string DataReader(string sql)
        {
            string kq = "";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader da = comm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    kq = da[0].ToString();
                }
            }
            conn.Close();
            return kq;
        }
    }
}
