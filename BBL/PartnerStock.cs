using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class PartnerStock
    {
        public string PatID { set; get; }
        public int qty { set; get; }
        public string ProID { set; get; }
        public string email { set; get; }


        public int patStockInsert()
        {
            try
            {
                string sql = "INSERT INTO PARTNER_STOCK VALUES('" + PatID + "'," + qty + ",'" + ProID + "','"+email+"')";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public DataSet manuviewAll()
        {
            string sql = "SELECT * FROM PARTNER_STOCK";
            return DB_Operations.executeSelectCommand(sql);

        }
    }
}
