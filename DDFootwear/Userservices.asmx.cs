using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BBL;
using System.Data;

namespace DDFootwear
{
    /// <summary>
    /// Summary description for Userservices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Userservices : System.Web.Services.WebService
    {
        [WebMethod]
        public int insertUser(string email, string password, string address, string type, string number)
        {
            User u1 = new User();
            u1.Uemail = email;
            u1.Upassword = password;
            u1.Uaddress = address;
            u1.Utype = type;
            u1.Unumber = number;

            return u1.userInsert();

        }

        [WebMethod]
        public int deleteUser(string email)
        {
            User u1 = new User();
            u1.Uemail = email;

            return u1.userDelete();
        }

        [WebMethod]
        public int updateUser(string email, string password, string address, string type, string number)
        {
            User u1 = new User();
            u1.Uemail = email;
            u1.Upassword = password;
            u1.Uaddress = address;
            u1.Utype = type;
            u1.Unumber = number;

            return u1.userUpdate();
        }

        [WebMethod]
        public User findUser(string email)
        {
            User u1 = new User();
            u1.Uemail = email;
            u1.find();
            return u1;
        }
        
        [WebMethod]
        public DataSet viewAllUsers()
        {
            User u1 = new User();
            return u1.viewAll();
        } 

        [WebMethod]
        public Boolean login(string uEmail,string password,string ut)
        {


            User u1 = new User();
            u1.Uemail = uEmail;
            if (u1.find())
            {
                if(u1.Upassword.Equals(password) && u1.Utype.Equals(ut))
                {
                    return true;
                }else
                {
                    return false;
                }
            }

            return false;
        }

        [WebMethod]
        public Boolean checkUser(string email)
        {
            User u1 = new User();
            u1.Uemail = email;
            return u1.find();
            
        }

    }
}