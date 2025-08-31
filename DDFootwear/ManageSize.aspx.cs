using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDFootwear
{
    public partial class ManageSize : System.Web.UI.Page
    {

        sizes.Size ss = new sizes.Size();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = ss.viewAllSizes();
            drvSizes.DataSource = ds;
            drvSizes.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int sID = Convert.ToInt32(txtSizeID.Text);
                int sNum = Convert.ToInt32(txtSizeNo.Text);


                if (ss.insertSize(sID, sNum) > 0)
                {
                    txtMessage.Text = "Size Record Inserted!";
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
                int sID = Convert.ToInt32(txtSizeID.Text);

                if (ss.deleteSize(sID) > 0)
                {
                    txtMessage.Text = "Size Record Deleted!";
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

                int sID = Convert.ToInt32(txtEnter.Text);
                sizes.Size1 s1 = ss.findSize(sID);

                txtSizenumUP.Text = s1.SizeNum.ToString();

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

                int sID = Convert.ToInt32(txtEnter.Text);
                int sNum = Convert.ToInt32(txtSizenumUP.Text);

                if (ss.updateUser(sID,sNum) > 0)
                {
                    txtMessage.Text = "Size Record Updated!";
                }

            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error " + ex.Message;
            }
        }
    }
}