namespace DefensoriaPublicaData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "LastName");
        }
    }
}
