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
    public partial class blance_page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
        public blance_page()
        {
            InitializeComponent();
           // label2.Text = name;
           // label4.Text = acc_num.ToString();
            
          
 
          
        }
     

        private void blance_page_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
            using (con)
            {
                con.Open();

                string q2 = "select *from  account_info   where add_no='" + txt_addhr.Text+ "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataReader read = cmd2.ExecuteReader();
                while (read.Read())
                {
                  //  MessageBox.Show(read[0].ToString());
                   textBox1.Text = read[0].ToString();

                  
                  
                }
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
            con2.Open();
          //  string q = "insert into balance_bd (account_no)value('" +textBox1.Text + "')";
            SqlCommand cmd3 = new SqlCommand("insert into balance_bd1(account_no,balance) values (" + Convert.ToInt32(textBox1.Text) + "," + Convert.ToInt32(textBox2.Text) + ")", con2);
             cmd3.ExecuteNonQuery();
            con2.Close();
            MessageBox.Show("your account created succesfuly");
            this.Close();
        }
    }
}
