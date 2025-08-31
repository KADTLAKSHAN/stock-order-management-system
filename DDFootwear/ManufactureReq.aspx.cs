using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BBL;

namespace DDFootwear
{
    public partial class ManufactureReq : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            Manufacture ss = new Manufacture();
            DataSet ds = ss.manuviewAll();
            drvManufacture.DataSource = ds;
            drvManufacture.DataBind();
        }
    }
}