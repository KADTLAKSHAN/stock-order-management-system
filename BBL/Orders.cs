using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class Orders
    {

        public string OrderID { set; get; }
        public string OrderDate { set; get; }
        public string Useremail { set; get; }
        public string DiscountID { set; get; }


        public int orderInsert()
        {
            try
            {
                string sql = "INSERT INTO ORDERS VALUES('" + OrderID + "','" + OrderDate + "','" + Useremail + "'," + DiscountID + ")";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public bool orderFind()
        {
            try
            {
                string sql = "SELECT * FROM ORDERS WHERE orderID='" + OrderID + "'";
                DataSet ds = DB_Operations.executeSelectCommand(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    OrderID = ds.Tables[0].Rows[0][0].ToString();
                    OrderDate = ds.Tables[0].Rows[0][1].ToString();
                    Useremail = ds.Tables[0].Rows[0][2].ToString();
                    DiscountID = ds.Tables[0].Rows[0][3].ToString();

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


    }
}
