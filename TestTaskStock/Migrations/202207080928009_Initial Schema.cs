namespace TestTaskStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        DetailID = c.Int(nullable: false, identity: true),
                        NomCode = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Qty = c.Int(nullable: false),
                        StockmanID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Deletedate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DetailID)
                .ForeignKey("dbo.Stockmen", t => t.StockmanID, cascadeDelete: true)
                .Index(t => t.StockmanID);
            
            CreateTable(
                "dbo.Stockmen",
                c => new
                    {
                        StockmanID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StockmanID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "StockmanID", "dbo.Stockmen");
            DropIndex("dbo.Details", new[] { "StockmanID" });
            DropTable("dbo.Stockmen");
            DropTable("dbo.Details");
        }
    }
}
