using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class Size
    {

        public int SizeID { set; get; }
        public int SizeNum { set; get; }

        public int sizeInsert()
        {
            try
            {
                string sql = "INSERT INTO SIZE VALUES(" + SizeID + "," + SizeNum + ")";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public int sizeDelete()
        {
            try
            {
                string sql = "DELETE FROM SIZE WHERE sizeID=" + SizeID;
                return DB_Operations.executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }


        public int sizeUpdate()
        {
            try
            {

                string sql = "UPDATE SIZE SET size= " + SizeNum + " WHERE sizeID=" + SizeID ;
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public bool sizefind()
        {
            try
            {
                string sql = "SELECT * FROM SIZE WHERE sizeID=" + SizeID;
                DataSet ds = DB_Operations.executeSelectCommand(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    SizeID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    SizeNum = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
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

        public DataSet sizeviewAll()
        {
            string sql = "SELECT * FROM SIZE";
            return DB_Operations.executeSelectCommand(sql);

        }

    }
}
