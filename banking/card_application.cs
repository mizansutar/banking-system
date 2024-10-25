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
         
    public partial class card_application : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
        public card_application()
        {
            InitializeComponent();
        }

        private void card_application_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string q = "insert into card_info (acc_num,c_type,curr) values (" + Convert.ToInt32(textBox1.Text) + ",'" + comboBox1.Text + "','"+comboBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("the application has been sented.....");
        }
    }
}
