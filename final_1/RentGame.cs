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
    public partial class RentGame : Form
    {
        public RentGame()
        {
            InitializeComponent();
        }

        private void RentGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDataSet.game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.gameRentalDataSet.game);

        }

        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select game_name,category,game_year,game_month,Rent_value from Game where game_name= '"+textBox1.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select game_name,category,game_year,game_month,Rent_value from Game ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select game_name,category,game_year,game_month,Rent_value from Game where category='"+textBox2.Text+"' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select game_name,category,game_year,game_month,Rent_value from Game,vendor where vendor.vendor_ID=Game.vendor_ID and vendor.Fname='" + textBox2.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select game_name,category,game_year,game_month,Rent_value from Game where game_year='" + textBox2.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con; 
            con.Open();
            SqlCommand cmd = new SqlCommand("update game set client_ID='" + textBox3.Text + "', Rent_value = 1 where game_name='" + textBox1.Text + "' ", con);
            SqlCommand cmd2 = new SqlCommand("update game set count_g = count_g + 1  where game_name='" + textBox1.Text + "' ", con);
            cmd3.CommandText = "insert into RentDate values ('" + textBox3.Text + "', (select vendor_ID from game where game_name='"+textBox1.Text+"') ,  GETDATE() , '" + textBox1.Text + "'  )";
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registertion is completed");

            /*SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClientPage C = new ClientPage();
            C.Show();
            this.Hide();
        }
    }
}
