using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact_02
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add1 = new Add();
            add1.Show();
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            this.Hide();
            update3 upd = new update3();
            upd.Show();
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete4 del = new delete4();
            del.Show();
        }

        private void btnview1_Click(object sender, EventArgs e)
        {
            this.Hide();
            view5 get1 = new view5();
            get1.Show();
        }
    }
}
