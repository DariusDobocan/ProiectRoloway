namespace ProiectRoloway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseId = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(),
                        ExpenseAmount = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.ExpenseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Expenses");
        }
    }
}
