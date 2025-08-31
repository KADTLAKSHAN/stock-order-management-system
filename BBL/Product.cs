using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class Product
    {
        public string PID { set; get; }
        public string PName { set; get; }
        public string PGender { set; get; }
        public double PPrice { set; get; }
        public int PQty { set; get; }
        public int PSize { set; get; }

        public int productInsert()
        {
            try
            {
                string sql = "INSERT INTO PRODUCT VALUES('" + PID + "','" + PName + "','" + PGender + "'," + PPrice + "," + PQty + ","+PSize+")";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public int productDelete()
        {
            try
            {
                string sql = "DELETE FROM PRODUCT WHERE productID='" + PID + "'";
                return DB_Operations.executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }


        public int productUpdate()
        {
            try
            {

                string sql = "UPDATE PRODUCT SET productName= '" + PName + "', gender='" + PGender + "', price=" + PPrice + ", quantity=" + PQty + ", sizeID="+PSize+ " WHERE productID='" + PID + "'";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public bool productFind()
        {
            try
            {
                string sql = "SELECT * FROM PRODUCT WHERE productID='" + PID + "'";
                DataSet ds = DB_Operations.executeSelectCommand(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    PID = ds.Tables[0].Rows[0][0].ToString();
                    PName = ds.Tables[0].Rows[0][1].ToString();
                    PGender = ds.Tables[0].Rows[0][2].ToString();
                    PPrice = Convert.ToDouble(ds.Tables[0].Rows[0][3]);
                    PQty = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
                    PSize = Convert.ToInt32(ds.Tables[0].Rows[0][5]);
                    return true;
                }
                else
                {
                    return false;
                }




            }
            catch
            {
                throw;
            }
        }

        public DataSet productViewAll()
        {
            string sql = "SELECT * FROM PRODUCT";
            return DB_Operations.executeSelectCommand(sql);

        }

        public int checkProduct()
        {
            try
            {
                string sql = "SELECT * FROM PRODUCT WHERE productID='" + PID + "'";
                return DB_Operations.executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }







    }
}
