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
    public partial class checkoutbook : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T09IFM3\\SQLEXPRESS;Initial Catalog=library; Integrated security = True");
        public checkoutbook()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkoutbook_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getbooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addissuedbook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Admission_Number", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@contact", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = comboBox1.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Checked out");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }
    }
}
