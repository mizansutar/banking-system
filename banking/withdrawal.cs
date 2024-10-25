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
    public partial class withdrawal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
        public withdrawal()
        {
            InitializeComponent();
        }
        public void Trac()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
            //DateTime.Now;
            con.Open();
            string temp = "withrawal";
            string temp2 = "bank withrawal";
            string q = "insert into transation_table (s_id,r_id,amount,tr_date,tr_type,ref) values('" + textBox1.Text + "','" +null+ "'," + Convert.ToInt32(textBox3.Text) + ",'" + DateTime.Now + "','" + temp + "','" + temp2 + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");

            using (con)
            {
                con.Open();

                string q = "select *from balance_bd1 where account_no=" + Convert.ToInt32(textBox1.Text) + "";
                SqlCommand cmd2 = new SqlCommand(q, con);
                SqlDataReader read = cmd2.ExecuteReader();
                while (read.Read())
                {
                    //   MessageBox.Show(read[1].ToString());
                    textBox2.Text = read[1].ToString();

                    //  read.Close();

                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text;
           
            SqlConnection con2= new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");

            con2.Open();
          int  temp = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text);
          if (temp < 0)
          {
              MessageBox.Show("insufficient amount");
          }
          else
          {
              textBox2.Text = temp.ToString();
              string q2 = "update  balance_bd1 set balance =" + Convert.ToInt32(textBox2.Text) + "where account_no=" + Convert.ToInt32(textBox1.Text) + "";
              SqlCommand cmd = new SqlCommand(q2, con2);
              cmd.ExecuteNonQuery();
              con2.Close();
              Trac();
              MessageBox.Show("withdrawal succefully....");

          }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
