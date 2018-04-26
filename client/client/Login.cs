using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            bool valid;
            bool isvalid;
            localhost.Service1 server = new localhost.Service1();
            server.Login(txtusername.Text, txtpassword.Text ,out valid, out isvalid);
            if (valid)
            {
                MessageBox.Show("Welcome");   
            }
            else 
            {
                MessageBox.Show("getout"); 
            }
            
        }

        private void lblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register R = new Register();
            this.Hide();

            R.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
