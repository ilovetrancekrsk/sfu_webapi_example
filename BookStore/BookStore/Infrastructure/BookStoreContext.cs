using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Threading.Tasks;
using BookStore.Infrastructure.Entities;
using BookStore.Infrastructure.Entities.Abstract;

namespace BookStore.Infrastructure
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Genre> Genres { get; set; }
        
        public DbSet<Author> Authors { get; set; }
        
        public DbSet<Book> Books { get; set; }

        #region AutoUpdate Created/Modified dates

        public override int SaveChanges()
        {
            setDatesProperies();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            setDatesProperies();
            return base.SaveChangesAsync();
        }

        private void setDatesProperies()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity as IEntity;
                if (entity != null)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedAt = DateTime.UtcNow;
                        entity.ModifiedAt = DateTime.UtcNow;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        entity.ModifiedAt = DateTime.UtcNow;
                    }
                }
            }
        }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}