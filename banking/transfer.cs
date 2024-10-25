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
//using System.DateTime;

namespace banking
{
    public partial class transfer : Form
    {
        public transfer()
        {
            InitializeComponent();
        }
        int f = 0;
        public void  Trac()
       {
           SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
           //DateTime.Now;
           con.Open();
           string temp = "transfer";
           string temp2 = "bank transfer";
           string q = "insert into transation_table (s_id,r_id,amount,tr_date,tr_type,ref) values('" + textBox1.Text + "','" + textBox3.Text + "',"+Convert.ToInt32(textBox6.Text)+",'" + DateTime.Now + "','" + temp + "','" + temp2 + "')";
           SqlCommand cmd = new SqlCommand(q, con);
           cmd.ExecuteNonQuery();
           con.Close();
       }
        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int STR = textBox1.Text.Length;
            if (STR >= 4)
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");

            con2.Open();
            int temp = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox5.Text);
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
               // MessageBox.Show("withdrawal succefully....");

            }

            con2.Open();
             temp = Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text);
            textBox4.Text = temp.ToString();
            string q3 = "update  balance_bd1 set balance =" + Convert.ToInt32(textBox4.Text) + "where account_no=" + Convert.ToInt32(textBox3.Text) + "";
            SqlCommand cmd3 = new SqlCommand(q3, con2);
            cmd3.ExecuteNonQuery();
            con2.Close();
           Trac();
            MessageBox.Show("transaction succefully.......");




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int STR = textBox3.Text.Length;
            if (STR == 4)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
                using (con)
                {
                    con.Open();

                    string q = "select *from balance_bd1 where account_no=" + Convert.ToInt32(textBox3.Text) + "";
                    SqlCommand cmd2 = new SqlCommand(q, con);
                    SqlDataReader read = cmd2.ExecuteReader();
                    while (read.Read())
                    {
                        //   MessageBox.Show(read[1].ToString());
                        textBox4.Text = read[1].ToString();

                        //  read.Close();

                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                
                    if (Convert.ToInt32(textBox5.Text) > Convert.ToInt32(textBox2.Text))
                    {
                        label8.Text = "low balnce";
                        button1.Enabled = false;
                        f = 1;
                    }
                
                else
                {
                    if (Convert.ToInt32(textBox5.Text) <=Convert.ToInt32(textBox2.Text))
                    {
                        label8.Text = "";
                        button1.Enabled = true;
                        f = 0;
                    }
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           if(textBox6.Text!="")
           {
               if (textBox5.Text.Length != textBox6.Text.Length)
               {
                   if (Convert.ToInt32(textBox5.Text) != Convert.ToInt32(textBox6.Text))
                   {

                       label7.Text = "doesn't match";
                       button1.Enabled=false;

                   }
               }
               else
               {
                   if( (Convert.ToInt32(textBox5.Text) == Convert.ToInt32(textBox6.Text))&&(f==0))
                   {
                       label7.Text = "";
                       button1.Enabled = true;
                   }
               }
           }
        }
    }
}