using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BBL
{
    public class User
    {
        public string Uemail { set; get; }
        public string Upassword { set; get; }
        public string Uaddress { set; get; }
        public string Utype { set; get; }
        public string Unumber { set; get; }

        //public List<User> userList = new List<User>();


        public int userInsert()
        {
            try
            {
                string sql = "INSERT INTO USERS VALUES('" + Uemail + "','" + Upassword + "','" + Uaddress + "','"+Utype+"','"+Unumber+"')";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public int userDelete()
        {
            try
            {
                string sql = "DELETE FROM USERS WHERE userEmail='" + Uemail + "'";
                return DB_Operations.executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }


        public int userUpdate()
        {
            try
            {

                string sql = "UPDATE USERS SET userPassword= '" + Upassword + "', userAddress='" + Uaddress + "', userType='"+Utype+ "', userPhoneNo='"+Unumber+"' WHERE userEmail='" + Uemail + "'";
                return DB_Operations.executeQuery(sql);

            }
            catch
            {
                throw;
            }
        }

        public bool find()
        {
            try
            {
                string sql = "SELECT * FROM USERS WHERE userEmail='"+Uemail+"'";
                DataSet ds = DB_Operations.executeSelectCommand(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    Uemail = ds.Tables[0].Rows[0][0].ToString();
                    Upassword = ds.Tables[0].Rows[0][1].ToString();
                    Uaddress = ds.Tables[0].Rows[0][2].ToString();
                    Utype = ds.Tables[0].Rows[0][3].ToString();
                    Unumber = ds.Tables[0].Rows[0][4].ToString();
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

        public DataSet viewAll()
        {
            string sql = "SELECT * FROM USERS";
            return DB_Operations.executeSelectCommand(sql);

        }

        //public List<User> readAll()
        //{
        //    string sql = "SELECT * FROM USERS";
        //    DataSet ds = DB_Operations.executeSelectCommand(sql);

        //    User u1 = new User();

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in ds.Tables[0].Rows)
        //        {
        //            foreach (DataColumn dc in ds.Tables[0].Columns)
        //            {
        //                u1.Uemail = dr[dc.ColumnName="userEmail"].ToString();
        //                u1.Upassword = dr[dc.ColumnName = "userPassword"].ToString();
        //                u1.Uaddress = dr[dc.ColumnName = "userAddress"].ToString();
        //                u1.Utype = dr[dc.ColumnName = "userType"].ToString();
        //                u1.Unumber = dr[dc.ColumnName = "userPhoneNo"].ToString();
        //                userList.Add(u1);
        //            }
                    
        //        }

        //        return userList;
        //    }
        //    else
        //    {
        //        return userList=null;
        //    }
        //}



    }
}
