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
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {

        [WebMethod]
        public int insertProduct(string pID, string pName, string gender, double price, int quantity,int size)
        {
            Product p1 = new Product();
            p1.PID = pID;
            p1.PName = pName;
            p1.PGender = gender;
            p1.PPrice = price;
            p1.PQty = quantity;
            p1.PSize = size;

            return p1.productInsert();

        }

        [WebMethod]
        public int deleteProduct(string pID)
        {
            Product p1 = new Product();
            p1.PID = pID;

            return p1.productDelete();
        }

        [WebMethod]
        public int updateProduct(string pID, string pName, string gender, double price, int quantity, int size)
        {
            Product p1 = new Product();
            p1.PID = pID;
            p1.PName = pName;
            p1.PGender = gender;
            p1.PPrice = price;
            p1.PQty = quantity;
            p1.PSize = size;

            return p1.productUpdate();
        }

        [WebMethod]
        public Product findProduct(string pID)
        {
            Product p1 = new Product();
            p1.PID = pID;
            p1.productFind();
            return p1;
        }

        [WebMethod]
        public DataSet viewAllProducts()
        {
            Product p1 = new Product();
            return p1.productViewAll();
        }


        [WebMethod]
        public Boolean checkProduct(string pID)
        {
            Product p1 = new Product();
            p1.PID = pID;
            return p1.productFind();
           
        }

    }
}
