﻿namespace TaskMasterTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusSeedDataToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) VALUES ('To do');");
            Sql("INSERT INTO Status (Name) VALUES ('In Progress');");
            Sql("INSERT INTO Status (Name) VALUES ('Done');");

        }

        public override void Down()
        {
            //Delete statements
        }
    }
}
