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

namespace WindowsFormsApp2
{
    public partial class crud : Form
    {
        string username, password;
        public crud()
        {
            InitializeComponent();
        }
        
         public crud(string x, string y)
        {
            InitializeComponent();
            this.username = x;
            this.password=y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string a = textBox2.Text;
                string b = textBox3.Text;
                string c = textBox5.Text;
                string d = this.username;

                string query = "UPDATE Register1Table SET Email = @Email, Firstname = @Firstname, Password = @Password WHERE Username = @Username";

                using (var con = new SqlConnection(@"Data Source=KOSHIN;Initial Catalog=Register1Table;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", a);
                    cmd.Parameters.AddWithValue("@Firstname", b);
                    cmd.Parameters.AddWithValue("@Password", c);
                    cmd.Parameters.AddWithValue("@Username", d); 

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected + " row(s) updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string d = this.username;

                string query = "DELETE FROM Register1Table WHERE Username = @Username";

                using (var con = new SqlConnection(@"Data Source=KOSHIN;Initial Catalog=Register1Table;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", d);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected + " row(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crud_Load(object sender, EventArgs e)
        {

        }
    }
}
