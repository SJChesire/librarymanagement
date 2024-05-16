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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T09IFM3\\SQLEXPRESS;Initial Catalog=library; Integrated security = True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("sp_loginnnn", con);
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox1.Text;
            cmmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader pr = cmmd.ExecuteReader();
            if (pr.Read())
            {
                userdash u = new userdash();
                u.Show();
                pr.Close();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
            con.Close();
        }
    }
}
