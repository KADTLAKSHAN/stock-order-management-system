using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDFootwear
{
    public partial class Userportal : System.Web.UI.Page
    {
        user.Userservices uu = new user.Userservices();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = uu.viewAllUsers();
            drvUsers.DataSource = ds;
            drvUsers.DataBind();
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtUserPassword.Text;
                string address = txtUserAddress.Text;
                string type = dplUserType.SelectedValue;
                string phone = txtUserContact.Text;

                if (uu.insertUser(email, password, address, type, phone) > 0)
                {
                    txtMessage.Text = "User Record Inserted!";
                }

            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error " + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEnter.Text;

                if (uu.deleteUser(email) > 0)
                {
                    txtMessage.Text = "User Record Deleted!";
                }

            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error " + ex.Message;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string email = txtEnter.Text;

                user.User u1 = uu.findUser(email);

                txtpassup.Text = u1.Upassword;
                txtaddressup.Text = u1.Uaddress;
                txtcontactup.Text = u1.Unumber;
                dplusertypeup.SelectedValue = u1.Utype;



            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error " + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string email = txtEnter.Text;
                string pass = txtpassup.Text;
                string address = txtaddressup.Text;
                string type = dplusertypeup.SelectedValue;
                string number = txtcontactup.Text;

                if (uu.updateUser(email, pass, address, type, number) > 0)
                {
                    txtMessage.Text = "User Record Updated!";
                }

            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error " + ex.Message;
            }
        }
    }
}