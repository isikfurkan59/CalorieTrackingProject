using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32.Entity
{
    public class User
    {

        
        public int UserID { get; set; }
        public string UserName { get; set; } // Kullanıcı Adı -- Mail olarak alınacak
        public string Password { get; set; }

        public virtual UserDetail UserDetail { get; set; }
        
    }
}
