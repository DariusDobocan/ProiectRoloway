namespace ProiectRoloway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expenses", "Deleted", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expenses", "Deleted");
        }
    }
}
