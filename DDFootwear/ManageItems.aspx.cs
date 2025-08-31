using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DDFootwear
{
    public partial class ManageItems : System.Web.UI.Page
    {
        product.ProductService p1 = new product.ProductService();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = p1.viewAllProducts();
            drvProducts.DataSource = ds;
            drvProducts.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string pID = txtProID.Text;
                string pName = txtProName.Text;
                string gender = dplGender.SelectedValue;
                double price = Convert.ToDouble(txtProPrice.Text);
                int qty = Convert.ToInt32(txtProQty.Text);
                int size = Convert.ToInt32(dplproSize.SelectedValue);



                if (p1.insertProduct(pID, pName,gender,price,qty,size)>0)
                {
                    txtMessage.Text = "Product Inserted!";
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
                string pID = txtProID.Text;

                if (p1.deleteProduct(pID) > 0)
                {
                    txtMessage.Text = "Product Deleted!";
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

                string pID = txtEnter.Text;
                product.Product pp = p1.findProduct(pID);

                txtProNameUP.Text = pp.PName.ToString();
                dplGenderUp.SelectedValue = pp.PGender.ToString();
                txtProPriceUp.Text = pp.PPrice.ToString();
                txtQuantityUp.Text = pp.PQty.ToString();
                dplsizeup.SelectedValue = pp.PSize.ToString();

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

                string pID = txtEnter.Text;
                string pName = txtProNameUP.Text;
                string gender = dplGenderUp.SelectedValue;
                double price = Convert.ToDouble(txtProPriceUp.Text);
                int qty = Convert.ToInt32(txtQuantityUp.Text);
                int size = Convert.ToInt32(dplsizeup.SelectedValue);

                if (p1.updateProduct(pID, pName, gender, price, qty, size) > 0)
                {
                    txtMessage.Text = "Product Record Updated!";
                }

            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error " + ex.Message;
            }
        }
    }
}