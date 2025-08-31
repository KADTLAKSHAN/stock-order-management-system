using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DB_Operations
    {
        private static string conString = "data source=DESKTOP-NBN8MLG\\SQLEXPRESS; Initial Catalog = DB_DD_Footwear; Integrated Security = True;";


        public static int executeQuery(string sql)
        {
            SqlConnection con = null;

            try
            {

                con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
                return com.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public static DataSet executeSelectCommand(string sql)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conString);

                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand com = new SqlCommand(sql, con);
                da.SelectCommand = com;
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                return ds;


            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }


        }
    }
}
