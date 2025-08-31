using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDFootwearWindowsApplication
{
    public partial class ManageOrders : Form
    {
        order.OrdersServices od = new order.OrdersServices();
        product.ProductService pd = new product.ProductService();

        private string oID;
        private string email;
        private Double Total = 0;
        private Double DisTotal = 0;

        public ManageOrders(string oID,string email)
        {
            InitializeComponent();
            this.oID = oID;
            this.email = email;
            txtOrderID.Text = this.oID;
        }

        public ManageOrders()
        {
            
        }

        

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_DD_FootwearDataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter1.Fill(this.dB_DD_FootwearDataSet1.PRODUCT);


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtProductID.Text) || string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Values Are Empty Please Check Again!");

            }else
            {
                string pID = txtProductID.Text;
                int qty = Convert.ToInt32(txtQty.Text);
                string stockID = txtStockID.Text;

                if (pd.checkProduct(pID))
                {
                    if (od.orderProduct(pID, qty, oID, email, stockID))
                    {
                        MessageBox.Show("Order is Completed!");

                        Total += od.calculateBill(pID, qty);
                        txtDisplayAmount.Text = Total.ToString("C");

                        DisTotal += od.DiscountCalculation(oID, Total);
                        txtDisTotal.Text = DisTotal.ToString("C");

                    }
                    else
                    {
                        MessageBox.Show("Quantity is not enough!");
                        MessageBox.Show("Added Manufacture List");
                    }

                }
                else
                {
                    MessageBox.Show("Product Not Found in Stock Please Check Again!");
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }
    }
}
