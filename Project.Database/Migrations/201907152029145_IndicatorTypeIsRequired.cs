namespace Project.Database.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class IndicatorTypeIsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Indicators", "Type", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Indicators", "Type", c => c.String(maxLength: 500));
        }
    }
}
