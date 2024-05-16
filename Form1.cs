using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagementsys
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T09IFM3\\SQLEXPRESS;Initial Catalog=library; Integrated security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("pr_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dashboard d = new dashboard();
                d.Show();
                dr.Close();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
            con.Close();
        }
    }
}
