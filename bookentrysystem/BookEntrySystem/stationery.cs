using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookEntrySystem
{
    public partial class stationery : Form
    {
        public stationery()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\bookEntrySystem\BookEntrySystem\BookEntrySystem\booksdb.mdf;Integrated Security=True;User Instance=True");

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtname.Text;
                String brand = txtbrand.Text;
                String code = txtcode.Text;
                int price = int.Parse(txtprice.Text);
 
                //sql query
                String query_insert = "insert into Tablestationery values('" + name + "','" + brand + "','" + code + "','" + price + "')";
                //sql command
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                cmnd.ExecuteNonQuery();

                MessageBox.Show("saved successfully!!");
                txtname.Text = " ";
                txtbrand.Text = " ";
                txtcode.Text = " ";
                txtprice.Text = " ";
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving!!" + ex);
            }
            finally
            {
                con.Close();
            }

        }

       private void btnsearchcode_Click(object sender, EventArgs e)
        {
            try
            {
                String u_code = txtsearchcode.Text;
                String query_search = "select *from Tablestationery where code='" + u_code + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    txtname.Text = r[0].ToString();
                    txtbrand.Text = r[1].ToString();
                    txtcode.Text = r[2].ToString();
                    txtprice.Text = r[3].ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching!!" + ex);
            }
            finally
            {
                con.Close();
            }
        }

       private void btnupdate_Click(object sender, EventArgs e)
       {
           try
           {
               String name = txtname.Text;
               String brand = txtbrand.Text;
               String code = txtcode.Text;
               int price = int.Parse(txtprice.Text);

               String query_update = "update Tablestationery set name='" + name + "',brand='" + brand + "',code='" + code + "',price='" + price + "' where code='" + code + "' ";
               SqlCommand cmnd = new SqlCommand(query_update, con);
               con.Open();
               cmnd.ExecuteNonQuery();
               MessageBox.Show("Successfully Data updated!!");
               txtname.Text = " ";
               txtbrand.Text = " ";
               txtcode.Text = " ";
               txtprice.Text = " ";


           }
           catch (Exception ex)
           {
               MessageBox.Show("error while updating" + ex);
           }
           finally
           {
               //con.Close();
           }
       }

       private void btndelete_Click(object sender, EventArgs e)
       {
           try
           {
               String name = txtname.Text;
               String brand = txtbrand.Text;
               String code = txtcode.Text;
               int price = int.Parse(txtprice.Text);

               String query_delete = "delete from Tablestationery where code='" + code + "'";
               SqlCommand cmnd = new SqlCommand(query_delete, con);
               con.Open();
               cmnd.ExecuteNonQuery();
               MessageBox.Show("successfully Data Deleted!!");
               txtname.Text = " ";
               txtbrand.Text = " ";
               txtcode.Text = " ";
               txtprice.Text = " ";

           }
           catch (Exception ex)
           {
               MessageBox.Show("error while deleting" + ex);

           }
           finally
           {
               con.Close();
           }
       }

      

       
     

        }


       

       
       
    }

