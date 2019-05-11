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
    public partial class BOOKS : Form
    {
        public BOOKS()
        {
            InitializeComponent();
        }

        private void btnnovels_Click(object sender, EventArgs e)
        {
            this.Hide();
            NOVEL obj = new NOVEL();
            obj.Show();
        }
        private void btnshortstory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShortStory obj = new ShortStory();
            obj.Show();
        }

        private void btntranslations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Translations obj = new Translations();
            obj.Show();

        }

        private void btnsubjectbooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectBooks obj = new SubjectBooks();
            obj.Show();

        }

      

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BOOKS_Load(object sender, EventArgs e)
        {

        }

      
       

       
    }
}
