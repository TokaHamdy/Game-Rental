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

namespace final_1
{
    public partial class UpDateAdmin : Form
    {
        public UpDateAdmin()
        {
            InitializeComponent();
        }

        private void UpDateAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlcon;
            sqlcon.Open();
            sqlcommand.CommandText = "UPDATE Admin SET  Fname = '" + textBox1.Text + "' , Lname = '" + textBox2.Text + "' ,  password = '" + textBox3.Text + "',  gender = '" + textBox4.Text + "' ,  bdate = '" + textBox5.Text + "' WHERE Admin_ID = '" + textBox6.Text + "' ";

            sqlcommand.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("the info updated successfully");
            AdminPage Ap = new AdminPage();
            Ap.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
