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
    public partial class loan_application : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
        public loan_application()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(textBox1.Text.Length>=4)
          {
              con.Open();
              string q = "insert into loan (acc_num,loan_amt,intrest_rate,duration,loan_type) values (" + Convert.ToInt32(textBox1.Text) + "," + Convert.ToInt32(textBox2.Text) + "," + Convert.ToInt32(comboBox1.Text) + "," + Convert.ToInt32(comboBox3.Text) + ",'" + comboBox2.Text + "')";
              SqlCommand cmd = new SqlCommand(q, con);
              cmd.ExecuteNonQuery();
              con.Close();
              MessageBox.Show("the application has been sented.....");

          }
          {
              MessageBox.Show("format un defined....");
          }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
