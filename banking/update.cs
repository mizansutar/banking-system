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
    public partial class update : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
          
        public update(int acc)
        {
            //label17.Text = acc.ToString();
            InitializeComponent();

            using (con)
            {
                con.Open();

                string q = "select *from account_info where acc_no=" + acc+ "";
                SqlCommand cmd2 = new SqlCommand(q, con);
                SqlDataReader read = cmd2.ExecuteReader();
                while (read.Read())
                {
                    //   MessageBox.Show(read[1].ToString());
                    label17.Text = read[0].ToString();
                    txt_fname.Text = read[1].ToString();
                    txt_lname.Text = read[2].ToString();
                    txt_mname.Text = read[3].ToString();

                    txt_mob.Text = read[4].ToString();

                    txt_adh.Text = read[5].ToString();
                    txt_email.Text = read[6].ToString();

                    txt_pan.Text = read[7].ToString();

                    txt_loc.Text = read[9].ToString();
                    txt_tal.Text = read[10].ToString();

                    txt_dist.Text = read[11].ToString();
                    txt_state.Text = read[12].ToString();
                    txt_pincode.Text = read[13].ToString();

                    comboBox1.Text = read[14].ToString();
                    //  read.Close();
                  //  DateTime tesr = new DateTime();
                  //  dateTimePicker1.Value =tesr ;
                }
            }
            con.Close();
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {


            SqlConnection con2= new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");
            con2.Open();
            string q = "update account_info  set fname='" + txt_fname.Text + "',lname='" + txt_lname.Text + "',   mname='" + txt_mname.Text + "',mobile_no='" + txt_mob.Text + "',add_no='" + txt_adh.Text + "',email_id='" + txt_email.Text + "',pan_no='" + txt_pan.Text + "', dob='" + dateTimePicker1.Text + "',  loc_add='" + txt_loc.Text + "',tal='" + txt_tal.Text + "',  dist='" + txt_dist.Text + "',state='" + txt_state.Text + "',pin_no='" + txt_pincode.Text + "',account_type='"+ comboBox1.Text + "'where acc_no=" + Convert.ToInt32(label17.Text) + "";
          
           
              
            
            
            

            SqlCommand cmd = new SqlCommand(q, con2);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("account updated  sucssefully.......");
        }
    }
}
