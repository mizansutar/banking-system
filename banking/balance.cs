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
    public partial class balance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
          
        public balance()
        {
            InitializeComponent();
        }

        private void balance_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }

        private void btn_check_Click(object sender, EventArgs e)
        {

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
    }
}
