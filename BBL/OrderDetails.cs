using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class OrderDetails
    {
        public int OdID { set; get; }
        public string OdPID { set; get; }
        public string OdOrderID { set; get; }
        public int Odqty { set; get; }


        public int productInsert()
        {
            try
            {
                string sql = "INSERT INTO ORDER_DETAILS VALUES('" + OdPID + "','" + OdOrderID + "'," + Odqty + ")";
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
                string sql = "DELETE FROM ORDER_DETAILS WHERE oDetailsID="+ OdID ;
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

                string sql = "UPDATE ORDER_DETAILS SET productID= '" + OdPID + "', orderID='" + OdID + "', quantity=" + Odqty + " WHERE oDetailsID=" + OdID ;
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
                string sql = "SELECT * FROM ORDER_DETAILS WHERE oDetailsID=" + OdID;
                DataSet ds = DB_Operations.executeSelectCommand(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    OdID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    OdPID = ds.Tables[0].Rows[0][1].ToString();
                    OdOrderID = ds.Tables[0].Rows[0][2].ToString();
                    Odqty = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
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
            string sql = "SELECT * FROM ORDER_DETAILS";
            return DB_Operations.executeSelectCommand(sql);

        }


    }
}
