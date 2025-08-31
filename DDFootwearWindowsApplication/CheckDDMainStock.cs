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
    public partial class CheckDDMainStock : Form
    {
        private string uEmail;
        private string tp;

        public CheckDDMainStock()
        {
            InitializeComponent();
        }

        public CheckDDMainStock(string uEmail, string tp)
        {
            InitializeComponent();
            this.uEmail = uEmail;
            this.tp = tp;
        }

        private void CheckDDMainStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_DD_FootwearDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.dB_DD_FootwearDataSet.PRODUCT);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if(cmbSearch.SelectedItem != null)
            {
                string pID = txtSearchBox.Text;
                if (cmbSearch.SelectedItem.Equals("Product ID"))
                {
                    this.pRODUCTTableAdapter.FillByproductID(this.dB_DD_FootwearDataSet.PRODUCT,pID);

                }else if(cmbSearch.SelectedItem.Equals("Product Name"))
                {
                    this.pRODUCTTableAdapter.FillByProductName(this.dB_DD_FootwearDataSet.PRODUCT, pID);
                }
            }
            else
            {
                MessageBox.Show("Please select search type");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            cmbSearch.SelectedItem = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OutletMenucs back = new OutletMenucs(uEmail,tp);
            back.Show();
            this.Hide();
        }
    }
}
