using System.Data.Entity.Migrations;
using BookStore.Infrastructure.Entities;

namespace BookStore.Infrastructure
{
    internal class DbSeed
    {
        private readonly BookStoreContext _dbContext;

        public DbSeed(BookStoreContext context)
        {
            _dbContext = context;
        }

        public void Run()
        {
            var comedy = new Genre
            {
                Title = "Comedy",
                Description = "Comedy description"
            };
            _dbContext.Genres.AddOrUpdate(comedy);

            var scifi = new Genre
            {
                Title = "Sci-Fi",
                Description = "Sci-Fi description"
            };
            _dbContext.Genres.AddOrUpdate(scifi);

            var fantasy = new Genre
            {
                Title = "Fantasy",
                Description = "Fantasy description"
            };
            _dbContext.Genres.AddOrUpdate(fantasy);
        }
    }
}