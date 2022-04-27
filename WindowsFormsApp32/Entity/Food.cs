using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32.Entity
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        ICollection<MealDetail> MealDetails { get; set; }
    }
}
