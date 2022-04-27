using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp32.Concrete;
using WindowsFormsApp32.Entity;

namespace WindowsFormsApp32
{
    public partial class NewUser : Form
    {
        private readonly CreateUser _createUser;

        public NewUser()
        {
            InitializeComponent();
            _createUser = new CreateUser();
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string mail = txtEmail.Text;
            int height;
            bool heightControl = int.TryParse(txtHeight.Text, out height);
            decimal weight;
            bool weightControl = decimal.TryParse(txtWeight.Text, out weight);
            int age;
            bool ageControl = int.TryParse(txtAge.Text, out age);


            if (_createUser.IsValidEmail(mail) && txtFirstName.TextLength >= 2 && txtLastName.TextLength >= 2
                && heightControl && weightControl && ageControl && txtPasword.TextLength==6 && txtPasword.Text!=txtFirstName.Text && txtPasword.Text!=txtLastName.Text && txtPasword.Text!="123456")
            { }
            else
            {
                MessageBox.Show("Please check the information you entered.(Your password cannot contain your first and last name.It must be six digits.)");
                return;
            }

            if (_createUser.IsThereInDatabase(mail) != true)
            {
                User user = new User();

                user.UserName = mail;
                user.Password = txtPasword.Text;

                UserDetail userDetail = new UserDetail();

                userDetail.FirstName = txtFirstName.Text;
                userDetail.LastName = txtLastName.Text;
                userDetail.Height = height;
                userDetail.Weight = weight;
                userDetail.Age = age;
                userDetail.Gender = GenderOf();
                

                _createUser.InsertToUser(user);
                _createUser.InsertToUserDetail(userDetail);

                MessageBox.Show("Account Created Successful.");
                this.Close();
            }
            else MessageBox.Show("This e-mail address has already been registered.");

        }

        private bool GenderOf() // Cinsiyet kontrolünü yapar.
        {
            if (rbMale.Checked)
            {
                bool men = true;
                return men;
            }
            else
            {
                bool women = false;
                return women;
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
