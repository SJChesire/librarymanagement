using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagementsys
{
    public partial class userdash : Form
    {
        public userdash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkoutbook c = new checkoutbook();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkinbook i = new checkinbook();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewbooks p = new viewbooks();
            p.Show();
        }
    }
}
