using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class Manufacture
    {

        public int ManuID { set; get; }
        public string Useremail { set; get; }
        public string ProID { set; get; }
        public int qty { set; get; }

        public int manuInsert()
        {
            try
            {
                string sql = "INSERT INTO MANUFACTURE_REQ VALUES('" + Useremail + "','" + ProID + "',"+qty+")";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public DataSet manuviewAll()
        {
            string sql = "SELECT * FROM MANUFACTURE_REQ";
            return DB_Operations.executeSelectCommand(sql);

        }


    }
}
