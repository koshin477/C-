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
using LoginApplication;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        //register button
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KOSHIN;Initial Catalog=Register1Table;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            
            {
               
                SqlCommand cmd = new SqlCommand("insert into Register1Table values(@Firstname,@Lastname,@Address,@Gender,@Email,@Phone,@Username,@Password)", con);
                cmd.Parameters.AddWithValue("@Firstname",textBox1.Text);
                cmd.Parameters.AddWithValue("@Lastname",textBox2.Text);
                cmd.Parameters.AddWithValue("@Address",textBox3.Text);
                cmd.Parameters.AddWithValue("@Gender",textBox4.Text);
                cmd.Parameters.AddWithValue("@Email",textBox5.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox6.Text);
                cmd.Parameters.AddWithValue("@Username",textBox7.Text);
                cmd.Parameters.AddWithValue("@Password",textBox8.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Registered");
             }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginpage form2 = new loginpage();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
