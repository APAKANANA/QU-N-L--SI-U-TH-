using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class clsKetnoi
    {
        SqlConnection connect = new SqlConnection();
        public clsKetnoi()
        {
            connect.ConnectionString = "data source= (local); initial catalog= Quanlysieuthi; integrated security=true";

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public DataTable LoadData(string sql)
        {
            SqlCommand command = new SqlCommand(sql,connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int Update(string sql, string[]name, object[]value,int nparameter)
        {
            SqlCommand command = new SqlCommand(sql, connect);
            for (int i = 0; i < nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();
        }
    }
}
