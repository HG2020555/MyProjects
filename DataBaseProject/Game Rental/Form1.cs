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

namespace Game_Rental
{
    public partial class Form1 : Form
    {
        private SqlCommand _sqlcommand;
        private SqlConnection _sqlConnection;
        private SqlConnection _con;
        private SqlCommand _cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesrental7DataSet.client' table. You can move, or remove it, as needed.
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.gamesrental7DataSet.client);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-D8O0BKG;Initial Catalog=gamesrental7;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO client VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("signing up has successfully executed");
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection("Data Source=DESKTOP-D8O0BKG;Initial Catalog=gamesrental7;Integrated Security=True");
            _con.Open();
            _cmd = new SqlCommand("UPDATE client SET Cpass=@a1 , Cname = @a2 Where CID = @a3", _con);
            _cmd.Parameters.Add("a1", Convert.ToString(textBox3.Text));
            _cmd.Parameters.Add("a2", Convert.ToString(textBox2.Text));
            _cmd.Parameters.Add("a3", Convert.ToString(textBox1.Text));
            _cmd.ExecuteNonQuery();
            _con.Close();
            MessageBox.Show("Update has successfully executed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
