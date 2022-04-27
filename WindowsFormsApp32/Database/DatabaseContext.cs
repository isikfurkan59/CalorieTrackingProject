using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp32.Entity;





namespace WindowsFormsApp32.Database
{
    internal class DatabaseContext : DbContext
    {
        //Veri tabanı bağlantısı
        public DatabaseContext() : base ("name=DatabaseContext")
        {

        }
        

        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }



    }
}
