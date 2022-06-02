namespace ProiectRoloway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expenses", "Deleted", c => c.String());
            AddColumn("dbo.Expenses", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expenses", "Category");
            DropColumn("dbo.Expenses", "Deleted");
        }
    }
}
