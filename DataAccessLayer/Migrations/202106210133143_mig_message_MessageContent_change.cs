﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_message_MessageContent_change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "MessageContent", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "MessageContent", c => c.Int(nullable: false));
        }
    }
}
