using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class OutletStock
    {
        public string OutID { set; get; }
        public int qty { set; get; }
        public string ProID { set; get; }
        public string email { set; get; }


        public int outStockInsert()
        {
            try
            {
                string sql = "INSERT INTO OUTLET_STOCK VALUES('" + OutID + "'," + qty + ",'" + ProID + "','" + email + "')";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public DataSet manuviewAll()
        {
            string sql = "SELECT * FROM OUTLET_STOCK";
            return DB_Operations.executeSelectCommand(sql);

        }
    }
}
