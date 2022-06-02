﻿namespace ProiectRoloway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expenses", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expenses", "Date");
        }
    }
}
