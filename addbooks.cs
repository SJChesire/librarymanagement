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
    public partial class addbooks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T09IFM3\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
        public addbooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_add_books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName",SqlDbType.NVarChar).Value=textBox1.Text;
            cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@BookQuantity", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Added");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }
    }
}
