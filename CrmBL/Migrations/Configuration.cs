using System.Data.Entity.Migrations;

namespace CrmBL.Migrations
{
    internal sealed class Configuration
        : DbMigrationsConfiguration<Model.CrmContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;

        protected override void Seed(Model.CrmContext context) { }
    }
}