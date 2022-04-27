using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp32.Database;

namespace WindowsFormsApp32.Concrete
{
    public class UserLogin
    {
        
        public static void UserConnection(string userName, string password) // Giriş yapmak isteyen kullanıcı sistemde kayıtlı ve id password doğru ise girişi sağlar.
        {
            using (var context = new DatabaseContext())
            {
                if (context.Users.Any(x => x.UserName == userName && x.Password == password))
                {
                    Login.ActiveForm.Hide();
                    Master openMaster = new Master();
                    openMaster.OpenProfile(userName);
                    openMaster.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Kayıtlı Üye Bulunamadı");
                }
            }
        }

    }
}
