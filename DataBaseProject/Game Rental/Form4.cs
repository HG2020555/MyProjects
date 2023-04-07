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
using System.Configuration;

namespace Game_Rental
{
    public partial class Form4 : Form
    {
        private object configurationManager;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesrental7DataSet.Game' table. You can move, or remove it, as needed.

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form4 = new Form3();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gameTableAdapter.Fill(this.gamesrental7DataSet.Game);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D8O0BKG;Initial Catalog=gamesrental7;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Game where GID=@GID",con);
            cmd.Parameters.AddWithValue("GID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }
    }
}


