namespace DataBaseManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Databases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ConnectionString = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Columns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Table_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tables", t => t.Table_Id)
                .Index(t => t.Table_Id);
            
            CreateTable(
                "dbo.Rows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Table_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tables", t => t.Table_Id)
                .Index(t => t.Table_Id);
            
            CreateTable(
                "dbo.Cells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        Column_Id = c.Int(),
                        Row_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Columns", t => t.Column_Id)
                .ForeignKey("dbo.Rows", t => t.Row_Id)
                .Index(t => t.Column_Id)
                .Index(t => t.Row_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rows", "Table_Id", "dbo.Tables");
            DropForeignKey("dbo.Cells", "Row_Id", "dbo.Rows");
            DropForeignKey("dbo.Cells", "Column_Id", "dbo.Columns");
            DropForeignKey("dbo.Columns", "Table_Id", "dbo.Tables");
            DropIndex("dbo.Cells", new[] { "Row_Id" });
            DropIndex("dbo.Cells", new[] { "Column_Id" });
            DropIndex("dbo.Rows", new[] { "Table_Id" });
            DropIndex("dbo.Columns", new[] { "Table_Id" });
            DropTable("dbo.Cells");
            DropTable("dbo.Rows");
            DropTable("dbo.Columns");
            DropTable("dbo.Tables");
            DropTable("dbo.Databases");
        }
    }
}
