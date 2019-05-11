using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookEntrySystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "samagibookshop123" && password == "admin123")
            {
                MessageBox.Show("Login success!");
                this.Hide();
                MAINMENU obj = new MAINMENU();
                obj.Show();
       
                
               
            }
            else
            {
                MessageBox.Show("Login failed!");
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

    }
}
