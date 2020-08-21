using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Econtact_02
{
    public partial class delete4 : Form
    {
        public delete4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm4 = new Home();
            hm4.Show();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\Disini\Desktop\Econtact_02(1)\Econtact_02\econtact02.mdf';Integrated Security=True;Connect Timeout=30");
        private void btndelete4_Click(object sender, EventArgs e)
        {
            string fname = txtfirstname4.Text;

            string del = "delete from econtact02 where First_Name = '"+fname+"'";
            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact Deleted");
            }
            catch(Exception ex4)
            {
                MessageBox.Show("" +ex4);
            }
        }
    }
}
