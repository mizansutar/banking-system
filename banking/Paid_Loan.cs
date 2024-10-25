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
   
    public partial class Paid_Loan : Form
    {
        public Paid_Loan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");

            con2.Open();
            int temp = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text);
            textBox2.Text = temp.ToString();
            string q2 = "update  loan set loan_amt =" + Convert.ToInt32(textBox3.Text) + "where acc_num=" + Convert.ToInt32(textBox1.Text) + "";
            SqlCommand cmd = new SqlCommand(q2, con2);
            cmd.ExecuteNonQuery();
            con2.Close();
            MessageBox.Show("the loan paided succefully....");
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

                    string q = "select *from loan where acc_num=" + Convert.ToInt32(textBox1.Text) + "";
                    SqlCommand cmd2 = new SqlCommand(q, con);
                    SqlDataReader read = cmd2.ExecuteReader();
                    while (read.Read())
                    {
                        //   MessageBox.Show(read[1].ToString());
                        textBox2.Text = read[2].ToString();

                        //  read.Close();

                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
