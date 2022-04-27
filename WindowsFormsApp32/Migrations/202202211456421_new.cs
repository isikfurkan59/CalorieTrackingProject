namespace WindowsFormsApp32.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserDetails", "Height", c => c.Int(nullable: false));
            AddColumn("dbo.UserDetails", "Weight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.UserDetails", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.UserDetails", "Boy");
            DropColumn("dbo.UserDetails", "Kilo");
            DropColumn("dbo.UserDetails", "Yas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDetails", "Yas", c => c.Int(nullable: false));
            AddColumn("dbo.UserDetails", "Kilo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.UserDetails", "Boy", c => c.Int(nullable: false));
            DropColumn("dbo.UserDetails", "Age");
            DropColumn("dbo.UserDetails", "Weight");
            DropColumn("dbo.UserDetails", "Height");
        }
    }
}
