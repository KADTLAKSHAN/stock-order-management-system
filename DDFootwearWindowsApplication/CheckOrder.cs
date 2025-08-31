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
    public partial class CheckOrder : Form
    {
        private string tp;
        private string uEmail;

        public CheckOrder()
        {
            
        }

        public CheckOrder(string uEmail, string tp)
        {
            InitializeComponent();
            this.uEmail = uEmail;
            this.tp = tp;
        }

        private void CheckOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_DD_FootwearDataSetOrder.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.FillByEmail(this.dB_DD_FootwearDataSetOrder.ORDERS,uEmail);

        }

        private void fillByEmailToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.oRDERSTableAdapter.FillByEmail(this.dB_DD_FootwearDataSetOrder.ORDERS, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OutletMenucs ou = new OutletMenucs(uEmail, tp);
            ou.Show();
            this.Hide();
        }
    }
}
