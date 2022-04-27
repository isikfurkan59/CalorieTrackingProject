using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32.Entity
{
    public class MealDetail
    {

        public int MealDetailID { get; set; }

        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }

        public int FoodID { get; set; }
        public virtual Food Food { get; set; }

        public int Count { get; set; }

        [Column("Calorie/Kcal")]
        public decimal Calorie { get; set; }





    }
}
