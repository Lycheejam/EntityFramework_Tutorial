using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Models
{
    internal sealed class Configuration : DbMigrationsConfiguration<BooksDbContext>
    {
        //自動マイグレーション機能を有効にする。
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EntityFrameworkTest.Models.BooksDbContext";
        }
    }
}
