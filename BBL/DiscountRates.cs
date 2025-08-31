using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class DiscountRates
    {

        public string DisID { set; get; }
        public double DisRate { set; get; }

        public int discountInsert()
        {
            try
            {
                string sql = "INSERT INTO DISCOUNT_RATE VALUES('" + DisID + "'," + DisRate + ")";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public int discountDelete()
        {
            try
            {
                string sql = "DELETE FROM DISCOUNT_RATE WHERE discountID='" + DisID +"'";
                return DB_Operations.executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }


        public int discountUpdate()
        {
            try
            {

                string sql = "UPDATE DISCOUNT_RATE SET disountRate= " + DisRate + " WHERE discountID='" + DisID +"'";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public bool discountfind()
        {
            try
            {
                string sql = "SELECT * FROM DISCOUNT_RATE WHERE discountID='" + DisID + "'";
                DataSet ds = DB_Operations.executeSelectCommand(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DisID = (ds.Tables[0].Rows[0][0]).ToString();
                    DisRate = Convert.ToDouble(ds.Tables[0].Rows[0][1]);
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

        public DataSet discountviewAll()
        {
            string sql = "SELECT * FROM DISCOUNT_RATE";
            return DB_Operations.executeSelectCommand(sql);

        }

    }
}
