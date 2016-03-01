using BookStore.Infrastructure;

namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Infrastructure.BookStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookStore.Infrastructure.BookStoreContext context)
        {
            if (context.Genres.Any())
                return;

            var seed = new DbSeed(context);
            seed.Run();
        }
    }
}
