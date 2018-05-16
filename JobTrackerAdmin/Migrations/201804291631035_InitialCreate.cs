namespace JobTrackerAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        clientId = c.Int(nullable: false, identity: true),
                        clientName = c.String(nullable: false),
                        clientAddress = c.String(),
                        clientContact = c.Int(nullable: false),
                        ClientPAN = c.String(),
                        clientGST = c.String(),
                        clientRemarks = c.String(),
                    })
                .PrimaryKey(t => t.clientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
