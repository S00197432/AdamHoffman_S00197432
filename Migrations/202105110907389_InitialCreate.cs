namespace AdamHoffman_S00197432.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        MetaCriticScore = c.String(),
                        Description = c.String(),
                        Platform = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReducedPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Game_image = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
