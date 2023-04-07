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
    public partial class Form2 : Form
    {
        private object sqlcommand2;
        private SqlConnection _con;
        private SqlCommand _cmd;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesrental7DataSet.vendor' table. You can move, or remove it, as needed.

        }
 
        private void button2_Click_1(object sender, EventArgs e)
        {
            _con = new SqlConnection("Data Source=DESKTOP-D8O0BKG;Initial Catalog=gamesrental7;Integrated Security=True");
            _con.Open();
            _cmd = new SqlCommand("UPDATE vendor SET Vpass=@a1 , Vname = @a2 Where VID = @a3", _con);
            _cmd.Parameters.Add("a1", Convert.ToString(textBox3.Text));
            _cmd.Parameters.Add("a2", Convert.ToString(textBox2.Text));
            _cmd.Parameters.Add("a3", Convert.ToString(textBox1.Text));
            _cmd.ExecuteNonQuery();
            _con.Close();
            MessageBox.Show("Update has successfully executed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-D8O0BKG;Initial Catalog=gamesrental7;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO vendor VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("signing up has successfully executed");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.vendorTableAdapter.Fill(this.gamesrental7DataSet.vendor);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
