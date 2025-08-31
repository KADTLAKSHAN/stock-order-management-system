using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using BBL;

namespace DDFootwear
{
    /// <summary>
    /// Summary description for DiscountService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DiscountService : System.Web.Services.WebService
    {

        [WebMethod]
        public int insertDiscount(string disID, double disRate)
        {
            DiscountRates dr = new DiscountRates();
            dr.DisID = disID;
            dr.DisRate = disRate;
            return dr.discountInsert();
        }

        [WebMethod]
        public int deleteDiscount(string disID)
        {
            DiscountRates dr = new DiscountRates();
            dr.DisID = disID;


            return dr.discountDelete();
        }

        [WebMethod]
        public int updateDiscount(string disID, double disRate)
        {
            DiscountRates dr = new DiscountRates();
            dr.DisID = disID;
            dr.DisRate = disRate;

            return dr.discountUpdate();
        }

        [WebMethod]
        public DiscountRates findSize(string disID)
        {
            DiscountRates dr = new DiscountRates();
            dr.DisID = disID;
            dr.discountfind();
            return dr;
        }

        [WebMethod]
        public DataSet viewAllSizes()
        {
            DiscountRates dr = new DiscountRates();
            return dr.discountviewAll();

        }
    }
}
