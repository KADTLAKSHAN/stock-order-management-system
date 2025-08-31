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
    public partial class Order : Form
    {
        order.OrdersServices od = new order.OrdersServices();
        private string email;
        private string tp;

        public Order()
        {
            
        }

        public Order(string email,string tp)
        {
            InitializeComponent();
            this.email = email;
            this.tp = tp;
            txtEmail.Text = email.ToString();
        }

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string oID = txtOrderID.Text;
                string date = dateTimePicker1.Value.ToString("yyyy-M-d");
                string dis = "3";

                if (tp.Equals("Partner"))
                {
                    dis = "1";
                }


                if (od.insertOrder(oID, date, email, dis) > 0)
                {
                    MessageBox.Show("Your Order ID is Created! Order ID = " + oID);
                    ManageOrders open = new ManageOrders(oID, email);
                    open.Show();
                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutletMenucs ou = new OutletMenucs(email,tp);
            ou.Show();
            this.Hide();

        }
    }
}
