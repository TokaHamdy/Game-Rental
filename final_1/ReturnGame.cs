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
    public partial class ReturnGame : Form
    {
        public ReturnGame()
        {
            InitializeComponent();
        }

        private void ReturnGame_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update game set client_ID= NULL, Rent_value = 0 where game_name='" + textBox1.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Game is Returned");
            ClientPage C = new ClientPage();
            C.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientPage C = new ClientPage();
            C.Show();
            this.Hide();
        }
    }
}
