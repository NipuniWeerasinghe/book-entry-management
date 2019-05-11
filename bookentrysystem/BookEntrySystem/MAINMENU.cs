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
    public partial class MAINMENU : Form
    {
        public MAINMENU()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BOOKS obj = new BOOKS();
            obj.Show();
        }

        private void btnstationery_Click(object sender, EventArgs e)
        {
            this.Hide();
            stationery obj = new stationery();
            obj.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
    

        

      

       

        
    }
}
