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
    public partial class PartnerStock : Form
    {
        private string uEmail;
        private string tp;

        public PartnerStock()
        {
            
        }

        public PartnerStock(string uEmail, string tp)
        {
            InitializeComponent();
            this.uEmail = uEmail;
            this.tp = tp;
        }

        private void PartnerStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_DD_FootwearDataSetPartnerStock.PARTNER_STOCK' table. You can move, or remove it, as needed.
            this.pARTNER_STOCKTableAdapter.FillByEmailPartner(this.dB_DD_FootwearDataSetPartnerStock.PARTNER_STOCK,uEmail);

        }

        private void fillByEmailPartnerToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pARTNER_STOCKTableAdapter.FillByEmailPartner(this.dB_DD_FootwearDataSetPartnerStock.PARTNER_STOCK, emailToolStripTextBox.Text);
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

        private void fillByProductIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pARTNER_STOCKTableAdapter.FillByProductID(this.dB_DD_FootwearDataSetPartnerStock.PARTNER_STOCK, pIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pID = txtSearchBox.Text;
            this.pARTNER_STOCKTableAdapter.FillByProductID(this.dB_DD_FootwearDataSetPartnerStock.PARTNER_STOCK,pID);
        }
    }
}
