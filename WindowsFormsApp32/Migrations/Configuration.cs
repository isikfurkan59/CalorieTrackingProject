namespace WindowsFormsApp32.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WindowsFormsApp32.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp32.Database.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WindowsFormsApp32.Database.DatabaseContext";
        }

        protected override void Seed(WindowsFormsApp32.Database.DatabaseContext context)
        {
            IList<MealType> mealTypeList = new List<MealType>()
            {
                new MealType() { MealTypeID = 1, MealTypeName = "Breakfast"},
                new MealType() { MealTypeID = 2, MealTypeName = "Lunch"},
                new MealType() { MealTypeID = 3, MealTypeName = "Dinner"},
                new MealType() { MealTypeID = 4, MealTypeName = "Snack"}
            };
            context.MealTypes.AddRange(mealTypeList);
            IList<Category> categoryList = new List<Category>()
            {
                new Category() { CategoryID = 1, CategoryName = "Fruits"},
                new Category() { CategoryID = 2, CategoryName = "Vegetable"},
                new Category() { CategoryID = 3, CategoryName = "Milk & Dairy Produtcs"},
                new Category() { CategoryID = 4, CategoryName = "Meat & Meat Produtcs"},
                new Category() { CategoryID = 5, CategoryName = "Soup"},
                new Category() { CategoryID = 6, CategoryName = "Breakfast"},
                new Category() { CategoryID = 7, CategoryName = "Cereal & Cereal Products"},
                new Category() { CategoryID = 8, CategoryName = "Main Courses"},
                new Category() { CategoryID = 9, CategoryName = "Snack"},
                new Category() { CategoryID = 10, CategoryName = "Drink"},

            };
            context.Categories.AddRange(categoryList);

            IList<Food> foodList = new List<Food>()
            {
                // Fruits
                new Food() { FoodID = 1, FoodName = "Apple", Calorie=95, CategoryID = 1},
                new Food() { FoodID = 2, FoodName = "Pear", Calorie=101, CategoryID = 1},
                new Food() { FoodID = 3, FoodName = "Avocado", Calorie=320, CategoryID = 1},
                new Food() { FoodID = 4, FoodName = "Quince", Calorie=52, CategoryID = 1},
                new Food() { FoodID = 5, FoodName = "Plum", Calorie=30, CategoryID = 1},
                new Food() { FoodID = 6, FoodName = "Date", Calorie=20, CategoryID = 1},
                new Food() { FoodID = 7, FoodName = "Fig", Calorie=37, CategoryID = 1},
                new Food() { FoodID = 8, FoodName = "Apricot", Calorie=17, CategoryID = 1},
                new Food() { FoodID = 9, FoodName = "Peach", Calorie=59, CategoryID = 1},
                new Food() { FoodID = 10, FoodName = "Cherry", Calorie=4, CategoryID = 1},
                new Food() { FoodID = 11, FoodName = "Kiwi", Calorie=112, CategoryID = 1},
                new Food() { FoodID = 12, FoodName = "Lemon", Calorie=17, CategoryID = 1},
                new Food() { FoodID = 13, FoodName = "Mango", Calorie=202, CategoryID = 1},
                new Food() { FoodID = 14, FoodName = "Banana", Calorie=111, CategoryID = 1},
                new Food() { FoodID = 15, FoodName = "Pomegranate", Calorie=234, CategoryID = 1},
                new Food() { FoodID = 16, FoodName = "Orange", Calorie=62, CategoryID = 1},
                new Food() { FoodID = 17, FoodName = "Strawberry", Calorie=49, CategoryID = 1},
                new Food() { FoodID = 18, FoodName = "Grape", Calorie=104, CategoryID = 1},


                //Vegetable
                new Food() { FoodID = 19, FoodName = "Okra", Calorie=4, CategoryID = 2},
                new Food() { FoodID = 20, FoodName = "Pepper", Calorie=20, CategoryID = 2},
                new Food() { FoodID = 21, FoodName = "Broccoli", Calorie=207, CategoryID = 2},
                new Food() { FoodID = 22, FoodName = "Tomato", Calorie=20, CategoryID = 2},
                new Food() { FoodID = 23, FoodName = "Engineer", Calorie=60, CategoryID = 2},
                new Food() { FoodID = 24, FoodName = "Carrot", Calorie=25, CategoryID = 2},
                new Food() { FoodID = 25, FoodName = "Courgette", Calorie=51, CategoryID = 2},
                new Food() { FoodID = 26, FoodName = "Asparagus", Calorie=2, CategoryID = 2},
                new Food() { FoodID = 27, FoodName = "Cabbage", Calorie=227, CategoryID = 2},
                new Food() { FoodID = 28, FoodName = "Mushrooms", Calorie=1, CategoryID = 2},
                new Food() { FoodID = 29, FoodName = "Lettuce", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 30, FoodName = "Sweetcorn", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 31, FoodName = "Potato", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 32, FoodName = "Aubergine", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 33, FoodName = "Leek", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 34, FoodName = "Cucumber", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 35, FoodName = "Garlic", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 36, FoodName = "Onion", Calorie=95, CategoryID = 2},
                new Food() { FoodID = 37, FoodName = "Radish", Calorie=95, CategoryID = 2},

                //Milk & Dairy Products
                new Food() { FoodID = 38, FoodName = "Buttermilk", Calorie=88, CategoryID = 3},
                new Food() { FoodID = 39, FoodName = "Cream", Calorie=144, CategoryID = 3},
                new Food() { FoodID = 40, FoodName = "Whipped Cream", Calorie=80, CategoryID = 3},
                new Food() { FoodID = 41, FoodName = "Milk", Calorie=149, CategoryID = 3},
                new Food() { FoodID = 42, FoodName = "Rice Pudding", Calorie=133, CategoryID = 3},
                new Food() { FoodID = 43, FoodName = "Cheese", Calorie=206, CategoryID = 3},
                new Food() { FoodID = 44, FoodName = "Yoghurt", Calorie=138, CategoryID = 3},
                new Food() { FoodID = 45, FoodName = "Cheddar", Calorie=144, CategoryID = 3},
                new Food() { FoodID = 46, FoodName = "Parmesan", Calorie=111, CategoryID = 3},
                new Food() { FoodID = 47, FoodName = "Mozzarella", Calorie=85, CategoryID = 3},
                new Food() { FoodID = 48, FoodName = "Feta", Calorie=75, CategoryID = 3},
                new Food() { FoodID = 49, FoodName = "Skim Milk", Calorie=90, CategoryID = 3},
                new Food() { FoodID = 50, FoodName = "Swiss Cheese", Calorie=100, CategoryID = 3},
                new Food() { FoodID = 51, FoodName = "Goat Cheese", Calorie=70, CategoryID = 3},
                new Food() { FoodID = 52, FoodName = "Brie", Calorie=100, CategoryID = 3},

                //Meat & Meat Products
                new Food() { FoodID = 53, FoodName = "Ribeye", Calorie=303, CategoryID = 4},
                new Food() { FoodID = 54, FoodName = "Tenderloin", Calorie=276, CategoryID = 4},
                new Food() { FoodID = 55, FoodName = "Filet Mignon", Calorie=278, CategoryID = 4},
                new Food() { FoodID = 56, FoodName = "Rib", Calorie=540, CategoryID = 4},
                new Food() { FoodID = 57, FoodName = "Roast Ribs", Calorie=376, CategoryID = 4},
                new Food() { FoodID = 58, FoodName = "Lamp Chops", Calorie=138, CategoryID = 4},
                new Food() { FoodID = 59, FoodName = "T-Bone Steak", Calorie=580, CategoryID = 4},
                new Food() { FoodID = 60, FoodName = "Chicken", Calorie=350, CategoryID = 4},
                new Food() { FoodID = 61, FoodName = "Chicken Leg", Calorie=346, CategoryID = 4},
                new Food() { FoodID = 62, FoodName = "Chicken Breast", Calorie=344, CategoryID = 4},
                new Food() { FoodID = 63, FoodName = "Chicken Wings", Calorie=77, CategoryID = 4},
                new Food() { FoodID = 64, FoodName = "Schnitzel", Calorie=203, CategoryID = 4},
                new Food() { FoodID = 65, FoodName = "Whitefish", Calorie=265, CategoryID = 4},
                new Food() { FoodID = 66, FoodName = "Sushi", Calorie=39, CategoryID = 4},
                new Food() { FoodID = 67, FoodName = "Salmon", Calorie=367, CategoryID = 4},

                //Soup
                new Food() { FoodID = 68, FoodName = "Split Pea Soup", Calorie=190, CategoryID = 5},
                new Food() { FoodID = 69, FoodName = "Broccoli", Calorie=206, CategoryID = 5},
                new Food() { FoodID = 70, FoodName = "Tomato Soup", Calorie=74, CategoryID = 5},
                new Food() { FoodID = 71, FoodName = "Meat Soup", Calorie=70, CategoryID = 5},
                new Food() { FoodID = 72, FoodName = "Carrot Soup", Calorie=95, CategoryID = 5},
                new Food() { FoodID = 73, FoodName = "Creamy Chicken Soup", Calorie=117, CategoryID = 5},
                new Food() { FoodID = 74, FoodName = "Creamy Chicken Soup", Calorie=97, CategoryID = 5},
                new Food() { FoodID = 75, FoodName = "Mushroom Soup", Calorie=85, CategoryID = 5},
                new Food() { FoodID = 76, FoodName = "Lentil Soup", Calorie=139, CategoryID = 5},
                new Food() { FoodID = 77, FoodName = "Vegetable Soup", Calorie=67, CategoryID = 5},
                new Food() { FoodID = 78, FoodName = "Chicken Soup", Calorie=78, CategoryID = 5},
                new Food() { FoodID = 79, FoodName = "Onion Soup", Calorie=56, CategoryID = 5},
                new Food() { FoodID = 80, FoodName = "Creamy Broccoli Soup", Calorie=140, CategoryID = 5},
                new Food() { FoodID = 81, FoodName = "Courgette Soup", Calorie=71, CategoryID = 5},
                new Food() { FoodID = 82, FoodName = "Noodle Soup", Calorie=83, CategoryID = 5},

                //Breakfast
                new Food() { FoodID = 83, FoodName = "Boiled Egg", Calorie=155, CategoryID = 6},
                new Food() { FoodID = 84, FoodName = "Fried Egg", Calorie=182, CategoryID = 6},
                new Food() { FoodID = 85, FoodName = "Olive", Calorie=10, CategoryID = 6},
                new Food() { FoodID = 86, FoodName = "Green Olive", Calorie=6, CategoryID = 6},
                new Food() { FoodID = 87, FoodName = "Honey", Calorie=15, CategoryID = 6},
                new Food() { FoodID = 88, FoodName = "Jam", Calorie=14, CategoryID = 6},
                new Food() { FoodID = 89, FoodName = "Peanut Butter", Calorie=65, CategoryID = 6},
                new Food() { FoodID = 90, FoodName = "Cheese", Calorie=206, CategoryID = 6},
                new Food() { FoodID = 91, FoodName = "Butter", Calorie=108, CategoryID = 6},
                new Food() { FoodID = 92, FoodName = "Toast", Calorie=86, CategoryID = 6},
                new Food() { FoodID = 93, FoodName = "Pancake", Calorie=89, CategoryID = 6},
                new Food() { FoodID = 94, FoodName = "Tomato", Calorie=20, CategoryID = 6},
                new Food() { FoodID = 95, FoodName = "Cucumber", Calorie=95, CategoryID = 6},
                new Food() { FoodID = 96, FoodName = "Ham", Calorie=145, CategoryID = 6},
                new Food() { FoodID = 97, FoodName = "Sausage", Calorie=146, CategoryID = 6},

                //Cereals & Cereal Products
                new Food() { FoodID = 98, FoodName = "Brown Bread", Calorie=63, CategoryID = 7},
                new Food() { FoodID = 99, FoodName = "Rye Bread", Calorie=65, CategoryID = 7},
                new Food() { FoodID = 100, FoodName = "Grain Bread", Calorie=66, CategoryID = 7},
                new Food() { FoodID = 101, FoodName = "Wholemeal Bread", Calorie=62, CategoryID = 7},
                new Food() { FoodID = 102, FoodName = "White Bread", Calorie=72, CategoryID = 7},
                new Food() { FoodID = 103, FoodName = "Corn Bread", Calorie=62, CategoryID = 7},
                new Food() { FoodID = 104, FoodName = "Sandwich Bread", Calorie=72, CategoryID = 7},
                new Food() { FoodID = 105, FoodName = "Bagel", Calorie=434, CategoryID = 7},
                new Food() { FoodID = 106, FoodName = "Tortilla Bread", Calorie=180, CategoryID = 7},
                new Food() { FoodID = 107, FoodName = "Scone", Calorie=145, CategoryID = 7},
                new Food() { FoodID = 108, FoodName = "Potato Bread", Calorie=85, CategoryID = 7},
                new Food() { FoodID = 109, FoodName = "Pretzel", Calorie=389, CategoryID = 7},
                new Food() { FoodID = 110, FoodName = "Pita Bread", Calorie=138, CategoryID = 7},
                new Food() { FoodID = 111, FoodName = "Muffin", Calorie=210, CategoryID = 7},
                new Food() { FoodID = 112, FoodName = "Flour Cookie", Calorie=95, CategoryID = 7},

                //Main Courses
                new Food() { FoodID = 113, FoodName = "Rice", Calorie=360, CategoryID = 8},
                new Food() { FoodID = 114, FoodName = "Pasta", Calorie=314, CategoryID = 8},
                new Food() { FoodID = 115, FoodName = "Meatball", Calorie=201, CategoryID = 8},
                new Food() { FoodID = 116, FoodName = "Baked Chicken", Calorie=350, CategoryID = 8},
                new Food() { FoodID = 117, FoodName = "Pizza", Calorie=272, CategoryID = 8},
                new Food() { FoodID = 118, FoodName = "Lasagna", Calorie=95, CategoryID = 8},
                new Food() { FoodID = 119, FoodName = "Fajitas", Calorie=95, CategoryID = 8},
                new Food() { FoodID = 120, FoodName = "Taco", Calorie=213, CategoryID = 8},
                new Food() { FoodID = 121, FoodName = "Ramen", Calorie=380, CategoryID = 8},
                new Food() { FoodID = 122, FoodName = "Biryani", Calorie=484, CategoryID = 8},
                new Food() { FoodID = 123, FoodName = "Burrito", Calorie=326, CategoryID = 8},
                new Food() { FoodID = 124, FoodName = "Corned Beef Hash", Calorie=349, CategoryID = 8},
                new Food() { FoodID = 125, FoodName = "Beans", Calorie=347, CategoryID = 8},
                new Food() { FoodID = 126, FoodName = "Beef Stew", Calorie=186, CategoryID = 8},
                new Food() { FoodID = 127, FoodName = "Mashed Potatoes", Calorie=174, CategoryID = 8},

                //Snack
                new Food() { FoodID = 128, FoodName = "Biscuit", Calorie=432, CategoryID = 9},
                new Food() { FoodID = 129, FoodName = "Cips", Calorie=510, CategoryID = 9},
                new Food() { FoodID = 130, FoodName = "Chocolate", Calorie=554, CategoryID = 9},
                new Food() { FoodID = 131, FoodName = "Cracker", Calorie=510, CategoryID = 9},
                new Food() { FoodID = 132, FoodName = "Croissant", Calorie=406, CategoryID = 9},
                new Food() { FoodID = 133, FoodName = "Pudding", Calorie=387, CategoryID = 9},
                new Food() { FoodID = 134, FoodName = "Muffin", Calorie=235, CategoryID = 9},
                new Food() { FoodID = 135, FoodName = "Cornflakes", Calorie=380, CategoryID = 9},
                new Food() { FoodID = 136, FoodName = "Cake", Calorie=280, CategoryID = 9},
                new Food() { FoodID = 137, FoodName = "Fruid Salad", Calorie=170, CategoryID = 9},
                new Food() { FoodID = 138, FoodName = "Popcorn", Calorie=374, CategoryID = 9},
                new Food() { FoodID = 139, FoodName = "Cookie", Calorie=120, CategoryID = 9},
                new Food() { FoodID = 140, FoodName = "Hazelnut", Calorie=310, CategoryID = 9},
                new Food() { FoodID = 141, FoodName = "Almond", Calorie=320, CategoryID = 9},
                new Food() { FoodID = 142, FoodName = "Cashew", Calorie=345, CategoryID = 9},

                //Drink
                new Food() { FoodID = 143, FoodName = "Coffee", Calorie=2, CategoryID = 10},
                new Food() { FoodID = 144, FoodName = "Coke", Calorie=139, CategoryID = 10},
                new Food() { FoodID = 145, FoodName = "Lemonade", Calorie=139, CategoryID = 10},
                new Food() { FoodID = 146, FoodName = "Milkshake", Calorie=112, CategoryID = 10},
                new Food() { FoodID = 147, FoodName = "Tea", Calorie=3, CategoryID = 10},
                new Food() { FoodID = 148, FoodName = "Hot Chocolate", Calorie=237, CategoryID = 10},
                new Food() { FoodID = 149, FoodName = "Orange Juice", Calorie=120, CategoryID = 10},
                new Food() { FoodID = 150, FoodName = "Diet Coke", Calorie=2, CategoryID = 10},
                new Food() { FoodID = 151, FoodName = "Beer", Calorie=153, CategoryID = 10},
                new Food() { FoodID = 152, FoodName = "Wine", Calorie=125, CategoryID = 10},
                new Food() { FoodID = 153, FoodName = "Ice Tea", Calorie=135, CategoryID = 10},
                new Food() { FoodID = 154, FoodName = "Enery Drink", Calorie=60, CategoryID = 10},
                new Food() { FoodID = 155, FoodName = "Soda", Calorie=105, CategoryID = 10},
                new Food() { FoodID = 156, FoodName = "Whiskey", Calorie=220, CategoryID = 10},
                new Food() { FoodID = 157, FoodName = "Tequila", Calorie=112, CategoryID = 10},
            };
            context.Foods.AddRange(foodList);
        }
    }
}
