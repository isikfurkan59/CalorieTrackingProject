using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WindowsFormsApp32.Database;
using WindowsFormsApp32.Entity;

namespace WindowsFormsApp32.Concrete
{
    public class CreateUser
    {
        private readonly DatabaseContext _context;
        public CreateUser()
        {
            _context = new DatabaseContext();
            
        }
        
        public void InsertToUser(User u) //Yeni Kullanıcı ekler.
        {
            var user = new User()
            {
                UserName = u.UserName,
                Password = u.Password
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void InsertToUserDetail(UserDetail ud) // Eklenen kullanıcıdan alınan bilgileri kaydeder.(İsim,Soyisim,Boy,Kilo vs.)
        {
            var result = _context.Users.Select(x => x.UserID).ToList().Last();

            var userDetail = new UserDetail()
            {
                UserID = result,
                FirstName = ud.FirstName,
                LastName = ud.LastName,
                Height = ud.Height,
                Weight = ud.Weight,
                Age = ud.Age,
                Gender = ud.Gender,
            };

            _context.UserDetails.Add(userDetail);
            _context.SaveChanges();

        }
        public bool IsThereInDatabase(string mail) // Database de aynı isimde kullanıcı olup olmadığını kontrol eder.
        {
            return _context.Users.Any(x => x.UserName == mail);
        }
        
        public bool IsValidEmail(string email) // Kayıt edilmesi istenen UserName in e-mail formatında olup olmadığını kontrol eder.
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
