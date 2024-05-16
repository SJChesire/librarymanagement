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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addbooks f = new addbooks();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewbooks v = new viewbooks();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addstudents s = new addstudents();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Returnedbooks i = new Returnedbooks();
            i.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            issueedbooks r = new issueedbooks();
            r.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewstudents w = new viewstudents();
            w.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
