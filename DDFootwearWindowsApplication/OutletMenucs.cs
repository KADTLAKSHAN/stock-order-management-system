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
    public partial class OutletMenucs : Form
    {
        private string tp;
        private string uEmail;

        public OutletMenucs()
        {
            InitializeComponent();
        }

        public OutletMenucs(string uEmail, string tp)
        {
            InitializeComponent();
            this.uEmail = uEmail;
            this.tp = tp;
        }

        private void btnDDStock_Click(object sender, EventArgs e)
        {
            CheckDDMainStock open = new CheckDDMainStock(uEmail,tp);
            open.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tp.Equals("Outlet"))
            {
                OutletStock op = new OutletStock(uEmail, tp);
                op.Show();
                this.Hide();
            }else
            {
                PartnerStock op2 = new PartnerStock(uEmail, tp);
                op2.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order open = new Order(uEmail,tp);
            open.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckOrder co = new CheckOrder(uEmail, tp);
            co.Show();
            this.Hide();
        }
    }
}
