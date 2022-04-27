namespace WindowsFormsApp32.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false),
                        Calorie = c.Double(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.MealDetails",
                c => new
                    {
                        MealDetailID = c.Int(nullable: false, identity: true),
                        MealID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        CalorieKcal = c.Decimal(name: "Calorie/Kcal", nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MealDetailID)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.MealID, cascadeDelete: true)
                .Index(t => t.MealID)
                .Index(t => t.FoodID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        MealDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                        MealTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MealID)
                .ForeignKey("dbo.MealTypes", t => t.MealTypeID, cascadeDelete: true)
                .ForeignKey("dbo.UserDetails", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.MealTypeID);
            
            CreateTable(
                "dbo.MealTypes",
                c => new
                    {
                        MealTypeID = c.Int(nullable: false, identity: true),
                        MealTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MealTypeID);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Boy = c.Int(nullable: false),
                        Kilo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Yas = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MealDetails", "MealID", "dbo.Meals");
            DropForeignKey("dbo.Meals", "UserID", "dbo.UserDetails");
            DropForeignKey("dbo.UserDetails", "UserID", "dbo.Users");
            DropForeignKey("dbo.Meals", "MealTypeID", "dbo.MealTypes");
            DropForeignKey("dbo.MealDetails", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropIndex("dbo.UserDetails", new[] { "UserID" });
            DropIndex("dbo.Meals", new[] { "MealTypeID" });
            DropIndex("dbo.Meals", new[] { "UserID" });
            DropIndex("dbo.MealDetails", new[] { "FoodID" });
            DropIndex("dbo.MealDetails", new[] { "MealID" });
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.UserDetails");
            DropTable("dbo.MealTypes");
            DropTable("dbo.Meals");
            DropTable("dbo.MealDetails");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}
