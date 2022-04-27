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
using WindowsFormsApp32.Database;
using System.IO;
using WindowsFormsApp32.Concrete;
using WindowsFormsApp32.Entity;


namespace WindowsFormsApp32
{
    
    public partial class Login : Form
    {

        DatabaseContext _context = new DatabaseContext();

        public Login()
        {
            InitializeComponent();
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
            _context.Database.CreateIfNotExists();
        }

        private void lblSingUp_Click(object sender, EventArgs e)
        {
            NewUser _user = new NewUser();
            _user.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtLoginEmail.Text;
            string password = txtLoginPassword.Text;
            
            UserLogin.UserConnection(userName, password);
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the Authorities. calorie@tracking.com");
        }
    }
}
