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
    public partial class statment : Form
    {
     
        public statment()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //con.Open();
            //string q = "Select * from transation_table ";
            //SqlDataAdapter da = new SqlDataAdapter(q, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statement_show sh = new statement_show(textBox1.Text);
            sh.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
