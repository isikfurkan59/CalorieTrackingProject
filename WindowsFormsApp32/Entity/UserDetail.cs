using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32.Entity
{
    public class UserDetail
    {
        [Key]
        [ForeignKey("User")]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; } // 1 ise erkek true

        public virtual User User { get; set; }
        ICollection<MealDetail> MealDetails { get; set; }


    }
}
