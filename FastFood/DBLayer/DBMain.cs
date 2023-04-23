using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFood.DBLayer
{
    class DBMain
    {
        string ConnStr = "Data Source=VANH;Initial Catalog=FASTFOOD_RESTAURANT_SYSTEM;Integrated Security=True";
        SqlConnection conn = null;
        public SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable getData(string strSQL)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable menu = new DataTable();
            adapter.Fill(menu);
            return menu;
        }
        public string Read_Firstcolumn(string strSQL, CommandType commandType)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            SqlDataReader da = comm.ExecuteReader();
            da.Read();
            return da.GetValue(0).ToString();
        }
        public void MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
          
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.ExecuteNonQuery();                 
        }
    }

}
