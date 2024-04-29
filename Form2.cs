using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using WindowsFormsApp2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginApplication
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KOSHIN;Initial Catalog=Register1Table;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


       

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username, password;

            username = usertxt.Text;
            password = passwordtxt.Text;

            try
            {
                String querry = "SELECT * FROM [Register1Table] WHERE Username= '" + usertxt.Text + "'AND Password='" + passwordtxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);



                DataTable dt = new DataTable();
                sda.Fill(dt);



                if (dt.Rows.Count > 0)
                {
                    username = usertxt.Text;
                    password = passwordtxt.Text;

                    string qr = "Select Username From [Register1Table] where Username='" + username + "'";

                    con.Open();
                    string x = con.QueryFirstOrDefault<string>(qr);

                    if (x == null)
                    {

                    }
                    else
                    {
                        crud form3 = new crud(username, password);
                        form3.Show();
                        this.Hide();

                    }
                    con.Close();




                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usertxt.Text = "";
                    passwordtxt.Text = "";



                    usertxt.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    }
