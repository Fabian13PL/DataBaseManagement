namespace DataBaseManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Columns", "TableName", c => c.String());
            AddColumn("dbo.Columns", "ColumnName", c => c.String());
            AddColumn("dbo.Columns", "DataType", c => c.String());
            AddColumn("dbo.Columns", "IsNotNull", c => c.Boolean(nullable: false));
            AddColumn("dbo.Columns", "IsPrimaryKey", c => c.Boolean(nullable: false));
            AddColumn("dbo.Columns", "IsUnique", c => c.Boolean(nullable: false));
            DropColumn("dbo.Columns", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Columns", "Name", c => c.String());
            DropColumn("dbo.Columns", "IsUnique");
            DropColumn("dbo.Columns", "IsPrimaryKey");
            DropColumn("dbo.Columns", "IsNotNull");
            DropColumn("dbo.Columns", "DataType");
            DropColumn("dbo.Columns", "ColumnName");
            DropColumn("dbo.Columns", "TableName");
        }
    }
}
