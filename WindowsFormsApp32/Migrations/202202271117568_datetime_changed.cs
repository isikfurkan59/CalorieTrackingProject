namespace WindowsFormsApp32.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime_changed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Meals", "MealDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Meals", "MealDate", c => c.DateTime(nullable: false));
        }
    }
}
