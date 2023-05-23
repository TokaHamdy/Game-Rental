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
    public partial class ClientPage : Form
    {
        public ClientPage()
        {
            InitializeComponent();
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDataSet.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter.Fill(this.gameRentalDataSet.Client);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateClient UC = new UpdateClient();
            UC.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientPage A = new ClientPage();
            A.Close();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentGame q = new RentGame();
            q.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnGame R = new ReturnGame();
            R.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select client_ID from Client where Fname='" + textBox2.Text + "' and Lname='" + textBox3.Text + "' and password='" + textBox4.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
