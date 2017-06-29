namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2906201700 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitors",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TournamentId = c.Long(nullable: false),
                        PlayerId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .ForeignKey("dbo.Tournaments", t => t.TournamentId, cascadeDelete: true)
                .Index(t => t.TournamentId)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competitors", "TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.Competitors", "PlayerId", "dbo.Players");
            DropIndex("dbo.Competitors", new[] { "PlayerId" });
            DropIndex("dbo.Competitors", new[] { "TournamentId" });
            DropTable("dbo.Tournaments");
            DropTable("dbo.Competitors");
        }
    }
}
