namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistrationUsers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        RePassword = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegistrationUsers");
        }
    }
}
