using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp36
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // GET USER AND PASS FROM THE TEXTBOX, REMOVE EXTRA SPACES
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // CHECK IF USER AND PASS IS EMPTY
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return; // STOP THE PROGRAM
            }

            // CALL OUT THE DB CONNECTION STRING
            DBConnect db = new DBConnect();

            try
            {
             db.Open(); // OPEN DATA BASE CONNECTION

                // SQL QUERY TO COUNT MATCHING USERNAME AND PASSWORD
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                // CREATE MYSQL COMMAND
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand( query, db.Connection);

                // ADD PARAMETERS TO PREVENT SQL INJECTION
                cmd.Parameters.AddWithValue("@username" , username );
                cmd.Parameters.AddWithValue ("Password" , password );

                // EXECUTE QUERY AND GET  RESULTS
                int count = Convert.ToInt32( cmd.ExecuteScalar());
                if ( count == 1)
                {
                    // IF 1 RECORD FOUND, LOGIN SUCCESSFUL
                    MessageBox.Show("login Successful");

                    // OPEN DASHBOARD
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    // NO MATCH FOUND
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex) 
            {
                // SHOW ERROR MESSAGE IF SOMETHING WENT WRONG
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
             db.Close(); // CLOSE DATA BASE CONNECTION
            }


        }
    }
}
