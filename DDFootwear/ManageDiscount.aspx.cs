using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DDFootwear
{
    public partial class ManageDiscount : System.Web.UI.Page
    {
        discount.DiscountService dd = new discount.DiscountService();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = dd.viewAllSizes();
            drvDiscount.DataSource = ds;
            drvDiscount.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string disID = txtDisID.Text;
                double disRate = Convert.ToDouble(txtDisRate.Text);


                if (dd.insertDiscount(disID,disRate) > 0)
                {
                    txtMessage.Text = "Discount Record Inserted!";
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
                string disID = txtEnter.Text;

                if (dd.deleteDiscount(disID) > 0)
                {
                    txtMessage.Text = "Discount Record Deleted!";
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

                string disID = txtEnter.Text;
                discount.DiscountRates d1 = dd.findSize(disID);

                txtDiscountUp.Text = d1.DisRate.ToString();

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

                string disID = txtEnter.Text;
                double disRate = Convert.ToDouble(txtDiscountUp.Text);

                if (dd.updateDiscount(disID,disRate) > 0)
                {
                    txtMessage.Text = "Discount Record Updated!";
                }

            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error " + ex.Message;
            }
        }
    }
}