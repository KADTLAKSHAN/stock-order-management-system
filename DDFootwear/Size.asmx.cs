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
    /// Summary description for Size
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Size : System.Web.Services.WebService
    {

        [WebMethod]
        public int insertSize(int sID, int sNum)
        {

            BBL.Size ss = new BBL.Size();
            ss.SizeID = sID;
            ss.SizeNum = sNum;
            return ss.sizeInsert();
        }

        [WebMethod]
        public int deleteSize(int sID)
        {
            BBL.Size ss = new BBL.Size();
            ss.SizeID = sID;
            

            return ss.sizeDelete();
        }

        [WebMethod]
        public int updateUser(int sID, int sNum)
        {
            BBL.Size ss = new BBL.Size();
            ss.SizeID = sID;
            ss.SizeNum = sNum;

            return ss.sizeUpdate();
        }

        [WebMethod]
        public BBL.Size findSize(int sID)
        {
            BBL.Size ss = new BBL.Size();
            ss.SizeID = sID;
            ss.sizefind();
            return ss;
        }

        [WebMethod]
        public DataSet viewAllSizes()
        {
            BBL.Size ss = new BBL.Size();
            return ss.sizeviewAll();
            
        }
    }
}
