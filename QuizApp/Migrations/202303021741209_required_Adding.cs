﻿namespace QuizApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required_Adding : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questions", "Ques", c => c.String(nullable: false));
            AlterColumn("dbo.Questions", "Option1", c => c.String(nullable: false));
            AlterColumn("dbo.Questions", "Option2", c => c.String(nullable: false));
            AlterColumn("dbo.Questions", "Option3", c => c.String(nullable: false));
            AlterColumn("dbo.Questions", "Option4", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "Option4", c => c.String());
            AlterColumn("dbo.Questions", "Option3", c => c.String());
            AlterColumn("dbo.Questions", "Option2", c => c.String());
            AlterColumn("dbo.Questions", "Option1", c => c.String());
            AlterColumn("dbo.Questions", "Ques", c => c.String());
        }
    }
}
