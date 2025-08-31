using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDFootwear
{
    public partial class Login : System.Web.UI.Page
    {
        user.Userservices uu = new user.Userservices();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string uName = txt_Username.Text;
            string pass = txt_password.Text;
            string ut = "Company";

            if(uu.login(uName, pass, ut))
            {

                Response.Redirect("CompanyPortal.aspx");

            }else
            {
                lblDisplay.Text = "Login Failed try again!";
            }
            
        }
    }
}