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
    public partial class Form3 : Form
    {
        private object sqlcommand3;
        private SqlConnection _con;
        private SqlCommand _cmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesrental7DataSet.Game' table. You can move, or remove it, as needed.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gameTableAdapter.Fill(this.gamesrental7DataSet.Game);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-D8O0BKG;Initial Catalog=gamesrental7;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO Game VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Adding game has successfully executed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection("Data Source=DESKTOP-D8O0BKG;Initial Catalog=gamesrental7;Integrated Security=True");
            _con.Open();
            _cmd = new SqlCommand("UPDATE Game SET Gname = @a2, category = @a3, price=@a4, state=@a5, VID = @a6 Where GID = @a1", _con);

            _cmd.Parameters.Add("a2", Convert.ToString(textBox3.Text));

            _cmd.Parameters.Add("a6", Convert.ToString(textBox2.Text));
            
            _cmd.Parameters.Add("a1", Convert.ToString(textBox1.Text));
            
            _cmd.Parameters.Add("a4", Convert.ToInt64(textBox6.Text));
            
            _cmd.Parameters.Add("a3", Convert.ToString(textBox5.Text));
            
            _cmd.Parameters.Add("a5", Convert.ToString(textBox4.Text));

            _cmd.ExecuteNonQuery();

            _con.Close();

            MessageBox.Show("Update has successfully executed");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
