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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm2 = new Home();
            hm2.Show();
        }

        string gender2;
        private void rdbtnmale2_CheckedChanged(object sender, EventArgs e)
        {
            gender2 = "Male";
        }

        private void rdbtnfemale2_CheckedChanged(object sender, EventArgs e)
        {
            gender2 = "Female";
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\Disini\Desktop\Econtact_02(1)\Econtact_02\econtact02.mdf';Integrated Security=True;Connect Timeout=30");
        private void btnadd2_Click(object sender, EventArgs e)
        {
            string firstname2 = txtfirstname2.Text;
            string lastname2 = txtlastname2.Text;
            string phonenumber12 = txtphonenumber12.Text;
            string phonenumber22 = txtphonenumber22.Text;
            string gendernew2 = gender2;
            string email2 = txtemail2.Text;
            string address2 = txtaddress2.Text;

            string qry = "insert into econtact02 values ('"+firstname2+"','"+lastname2+"','"+phonenumber12+"','"+phonenumber22+"','"+gendernew2+"','"+email2+"','"+address2+"')";
            SqlCommand cmd = new SqlCommand(qry,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact added successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("" +ex);
            }
        }
    }
}
