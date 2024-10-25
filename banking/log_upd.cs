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
    public partial class log_upd : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
        public log_upd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q1 = "select count(*) from  account_info   where acc_no  =" + Convert.ToInt32(textBox1.Text)+ " ";
            SqlCommand cmd = new SqlCommand(q1, con);
          
            //cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count> 0)
            {
                update up = new update(Convert.ToInt32(textBox1.Text));
                up.Show();

            }
            else
            {
                MessageBox.Show("USER DOESN'T EXIST......");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
