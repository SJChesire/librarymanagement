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
    public partial class Returnedbooks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T09IFM3\\SQLEXPRESS;Initial Catalog=library; Integrated security = True");
        public Returnedbooks()
        {
            InitializeComponent();
        }

        private void Returnedbooks_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_viewcheckedinbooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Admission_number", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_viewcheckedinbooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Admission_number", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
