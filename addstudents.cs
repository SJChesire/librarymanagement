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
    public partial class addstudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T09IFM3\\SQLEXPRESS;Initial Catalog=library; Integrated security = True");
        public addstudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Admission_Number", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@contact", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Details Added");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }

        private void addstudents_Load(object sender, EventArgs e)
        {

        }
    }
}
