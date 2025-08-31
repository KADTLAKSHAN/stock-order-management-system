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
    public partial class OutletStock : Form
    {
        private string tp;
        private string uEmail;

        public OutletStock()
        {
            
        }

        public OutletStock(string uEmail, string tp)
        {
            InitializeComponent();
            this.uEmail = uEmail;
            this.tp = tp;
        }

        private void OutletStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_DD_FootwearDataSetOutletStock.OUTLET_STOCK' table. You can move, or remove it, as needed.
            this.oUTLET_STOCKTableAdapter.FillByOutletemail(this.dB_DD_FootwearDataSetOutletStock.OUTLET_STOCK,uEmail);

        }

        private void fillByOutletemailToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.oUTLET_STOCKTableAdapter.FillByOutletemail(this.dB_DD_FootwearDataSetOutletStock.OUTLET_STOCK, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OutletMenucs open = new OutletMenucs(uEmail, tp);
            open.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pp = txtSearchBox.Text;
            this.oUTLET_STOCKTableAdapter.FillByProductID(this.dB_DD_FootwearDataSetOutletStock.OUTLET_STOCK, pp);
        }

        private void fillByProductIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.oUTLET_STOCKTableAdapter.FillByProductID(this.dB_DD_FootwearDataSetOutletStock.OUTLET_STOCK, pIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
