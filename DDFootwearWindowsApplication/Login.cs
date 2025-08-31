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
    public partial class Login : Form
    {
        user.Userservices uu = new user.Userservices();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLoginEmail.Text) || string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("Fields Empty Please Check Again Your Values");

            }else
            {
                string uEmail = txtLoginEmail.Text;
                string uPass = txtLoginPassword.Text;
                string tp = comboBox1.SelectedItem.ToString();

                if (uu.login(uEmail, uPass, tp))
                {

                        OutletMenucs open = new OutletMenucs(uEmail, tp);
                        open.Show();
                        this.Hide();


                }
                else
                {
                    MessageBox.Show("Loging Failed!");
                }

            }
        }
    }
}
