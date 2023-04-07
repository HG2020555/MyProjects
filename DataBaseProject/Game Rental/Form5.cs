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
    public partial class Form5 : Form

    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.gamesrental7ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        public Form5()
        {
            InitializeComponent();
        }

        

        private void btnquery_Click(object sender, EventArgs e)
        {
            string query = txtquery.Text;
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if(ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void Fill(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
