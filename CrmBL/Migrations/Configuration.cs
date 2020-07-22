using System.Data.Entity.Migrations;
using CrmBL.DataBase;

namespace CrmBL.Migrations
{
    internal sealed class Configuration
        : DbMigrationsConfiguration<CrmContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;

        protected override void Seed(CrmContext context) { }
    }
}