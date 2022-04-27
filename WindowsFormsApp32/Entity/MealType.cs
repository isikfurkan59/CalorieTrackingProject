using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32.Entity
{
    public class MealType
    {
        public int MealTypeID { get; set; }
        public string MealTypeName { get; set; }

        ICollection<MealDetail> MealDetails { get; set; }
    }
}
