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

   
    public partial class opening : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0INLRA4;Initial Catalog=banking sys_mizan;Integrated Security=True");

        public opening()
        {
            InitializeComponent();
           
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if ((txt_fname.Text != "") && (txt_lname.Text != "")&&(txt_mname.Text != "") && (txt_mobile.Text != "") && (txt_addhar.Text != "") && (txt_email.Text != "") && (txt_pan.Text != "") && (dob_picker.Text != "") && (txt_loc_add.Text != "") && (txt_tal.Text != "") && (txt_dist.Text != "") && (txt_state.Text != "") && (txt_pin.Text != "") && (comboBox1.Text != "")) 
            {
                con.Open();
                string q1 = "select count(*) from  account_info   where add_no=@d ";
                SqlCommand cmd= new SqlCommand(q1, con);
                cmd.Parameters.AddWithValue("@d", txt_addhar.Text);
                //cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("the user exist");

                }
                else
                {
                    con.Open();
                    string q = "insert into account_info (fname,lname,mname,mobile_no,add_no,email_id,pan_no,dob,loc_add,tal,dist,state,pin_no,account_type)values('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_mname.Text + "','" + txt_mobile.Text + "','" + txt_addhar.Text + "','" + txt_email.Text + "','" + txt_pan.Text + "','" + dob_picker.Text + "','" + txt_loc_add.Text + "','" + txt_tal.Text + "','" + txt_dist.Text + "','" + txt_state.Text + "','" + txt_pin.Text + "','" + comboBox1.Text + "')";
                    SqlCommand cmdn = new SqlCommand(q, con);
                    cmdn.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("account created sucssefully.......");
               // string temp;
                      //blance_page pb = new blance_page();
                      // pb.Show();
                    //using (con)
                    //{
                    //    con.Open();
                        
                    //    string q2 = "select *from  account_info   where add_no='"+txt_addhar.Text+"'";
                    //    SqlCommand cmd2 = new SqlCommand(q2, con);
                    //    SqlDataReader read = cmd2.ExecuteReader();
                    //    while(read.Read())
                    //    {
                    //        MessageBox.Show(read[0].ToString());
                    //         temp= read[0].ToString();
                    //         blance_page pb = new blance_page(txt_fname.Text, Convert.ToInt32(read[0]));
                    //         pb.Show();
                    //        //blance_page pb = new blance_page(txt_fname.Text, read[0].ToString());
                            
                    //    }
                       
                   //     MessageBox.Show("balance data created succefully");
       
                    


                    
                 

                    txt_fname.Text = ""; 
                    txt_lname.Text = ""; 
                    txt_mname.Text = "";
                    txt_mobile.Text = "";
                    txt_addhar.Text = "";
                    txt_email.Text = ""; 
                    txt_pan.Text = "";
                    dob_picker.Text = "";
                    txt_loc_add.Text = "";
                    txt_tal.Text = "";
                    txt_dist.Text = ""; 
                    txt_state.Text = "";
                    txt_pin.Text = "";
                    comboBox1.Text = "";
                    txt_fname.Focus();

                    blance_page pb = new blance_page();
                    pb.Show();

                   

                }
                

            }
            else
            {
                MessageBox.Show("please fill all the above fields......");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            txt_fname.Text = "";  txt_lname.Text = "";txt_mname.Text = "";  txt_mobile.Text = "";  txt_addhar.Text = "";  txt_email.Text = "";  txt_pan.Text = "";  dob_picker.Text = "";  txt_loc_add.Text = "";  txt_tal.Text = "";  txt_dist.Text = "";  txt_state.Text = "";  txt_pin.Text = "";  comboBox1.Text = "";
        }
    }
}
