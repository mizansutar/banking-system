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
    public partial class card_sttscs : Form
    {
        public card_sttscs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int STR = textBox1.Text.Length;
            if (STR >= 4)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
                using (con)
                {
                    con.Open();

                    string q = "select * from card_info where acc_num=" + Convert.ToInt32(textBox1.Text) + "";
                    SqlCommand cmd2 = new SqlCommand(q, con);
                    SqlDataReader read = cmd2.ExecuteReader();
                    while (read.Read())
                    {
                        //   MessageBox.Show(read[1].ToString());
                        textBox2.Text = read[2].ToString();
                        textBox3.Text = read[3].ToString();
                        //  read.Close();

                    }

                }
            }
        }
    }
}
