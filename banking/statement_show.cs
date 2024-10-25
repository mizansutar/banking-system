using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace banking
{
    public partial class statement_show : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
        public statement_show(string account)
        {
           

            InitializeComponent();
            label1.Text = account;
            con.Open();
            string q = "Select * from transation_table where s_id='"+label1.Text+"'";

           
            SqlDataAdapter da=new SqlDataAdapter(q,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statement_show_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
