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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace librarymanagementsys
{
    public partial class checkinbook : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T09IFM3\\SQLEXPRESS;Initial Catalog=library; Integrated security = True");
        public checkinbook()
        {
            InitializeComponent();
        }

        private void checkinbook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addcheckinbooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Admission_Number", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Checked in");
            con.Close();
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }
    }
}
