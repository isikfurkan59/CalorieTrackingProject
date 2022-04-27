using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32.Entity
{
    public class Meal
    {

        public int MealID { get; set; }
        [Required, Column(TypeName = "Date")]
        public DateTime MealDate { get; set; } = DateTime.Now;

        [ForeignKey("UserDetail")]
        public int UserID { get; set; }
        public virtual UserDetail UserDetail { get; set; }


        public int MealTypeID { get; set; }
        public MealType MealType { get; set; }


        ICollection<MealDetail> MealDetails { get; set; }

    }
}
