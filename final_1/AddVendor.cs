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
    public partial class AddVendor : Form
    {
        public AddVendor()
        {
            InitializeComponent();
        }

        private void AddVendor_Load(object sender, EventArgs e)
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
            sqlcommand.CommandText = "INSERT INTO vendor VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            sqlcommand.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Vendor is added successfully");
            AdminPage Ap = new AdminPage();
            Ap.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage A = new AdminPage();
            A.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
