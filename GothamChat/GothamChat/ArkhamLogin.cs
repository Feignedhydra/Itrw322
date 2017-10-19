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
using System.Net;
using System.Net.Sockets;
namespace GothamChat
{
    public partial class ArkhamLogin : MetroFramework.Forms.MetroForm
    {
      
            
        public ArkhamLogin()
        {
            InitializeComponent();
           
        }
        #region Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            SqlDataReader reader = null;
            connectionString = "Data Source = mssql6.gear.host;Initial Catalog = gothamsbasement; User ID=gothamsbasement;Password=Az07-!2eCy11; MultipleActiveResultSets=True";
            cnn = new SqlConnection(connectionString);
            //try
            //{
            cnn.Open();

            //    MessageBox.Show("Connection Open!");
            //    cnn.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Can not open connection!");
            //}
            SqlCommand CommUserDetail = new SqlCommand("select * from Login where Username = @Username and Password=@Password", cnn);
            //SqlCommand CommPassword = new SqlCommand("select * from Login where Password = @Password", cnn);
            CommUserDetail.Parameters.AddWithValue("@Username", tbxUsername.Text);
            CommUserDetail.Parameters.AddWithValue("@Password", tbxPassword.Text);
            reader = CommUserDetail.ExecuteReader();

            if (reader != null && reader.HasRows)
            {
                WayneINC dash = new WayneINC(tbxUsername.Text);
                GothamChat Cname = new GothamChat(tbxUsername.Text);
                
                dash.Show();
                cnn.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password combination is incorrect");
                cnn.Close();
                
            }
        }
        #endregion
        #region Email Validation
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        
        private void ArkhamLogin_Load(object sender, EventArgs e)
        {
            
            
        }
        #region SignUp
        private void btnSignup_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            SqlDataReader reader1 = null;
            SqlDataReader reader2 = null;
            connectionString = "Data Source = mssql6.gear.host;Initial Catalog = gothamsbasement; User ID=gothamsbasement;Password=Az07-!2eCy11; MultipleActiveResultSets=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand MatchUname = new SqlCommand("SELECT * FROM Login WHERE Username = @Username", cnn);
            SqlCommand MatchEmail = new SqlCommand("SELECT * FROM Login WHERE Email = @Email", cnn);
            MatchUname.Parameters.AddWithValue("@Username", tbxSusername.Text);
            MatchEmail.Parameters.AddWithValue("@Email", tbxSemail.Text);
            reader1 = MatchUname.ExecuteReader();
            reader2 = MatchEmail.ExecuteReader();
            if (tbxSusername.Text != "" && tbxSpassword.Text != "" && tbxSName.Text != "" && tbxSsurname.Text != "" && tbxSemail.Text != "")
            {
                if (reader1 != null && reader1.HasRows)//checks if any username in the database matches
                {
                    MessageBox.Show("Username already exists");
                    cnn.Close();
                }
                else if (reader2 != null && reader2.HasRows)///checks if any email in the database matches
                {
                    MessageBox.Show("Email is being used by another account");
                    cnn.Close();
                }
                else
                {

                    if (IsValidEmail(Convert.ToString(tbxSemail.Text)) == true)//if email is valid add user information into the database
                    {
                        SqlCommand addUser = new SqlCommand();
                        addUser.Connection = cnn;
                        addUser.CommandType = CommandType.Text;
                        addUser.CommandText = "insert into Login(Username, Password, Email, Name, Surname) values (@Username, @Password, @Email, @Name, @Surname)";
                        addUser.Parameters.Add(new SqlParameter("@Username", tbxSusername.Text));
                        addUser.Parameters.Add(new SqlParameter("@Password", tbxSpassword.Text));
                        addUser.Parameters.Add(new SqlParameter("@Email", tbxSemail.Text));
                        addUser.Parameters.Add(new SqlParameter("@Name", tbxSName.Text));
                        addUser.Parameters.Add(new SqlParameter("@Surname", tbxSsurname.Text));
                        addUser.ExecuteNonQuery();
                        MessageBox.Show("Account created!");
                        cnn.Close();
                        WayneINC dash = new WayneINC(tbxUsername.Text);
                        GothamChat Cname = new GothamChat(tbxSusername.Text);

                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email address.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure that no field is empty.");
            }

        }
        #endregion
        private void lblNewAccount_Click(object sender, EventArgs e)
        {
            #region Visibility change
            lblSusername.Visible = true;
            lblSpassword.Visible = true;
            lblSname.Visible = true;
            lblSsurname.Visible = true;
            lblSemail.Visible = true;
            btnSignup.Visible = true;
            tbxSemail.Visible = true;
            tbxSsurname.Visible = true;
            tbxSName.Visible = true;
            tbxSpassword.Visible = true;
            tbxSusername.Visible = true;

            lblPassword.Visible = false;
            lblNewAccount.Visible = false;
            lblUsername.Visible = false;
            lLblForgot.Visible = false;
            btnLogin.Visible = false;
            tbxUsername.Visible = false;
            tbxPassword.Visible = false;
            #endregion
        }
    }
}
