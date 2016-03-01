using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Infrastructure.Entities.Abstract
{
    public abstract class Entity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }
    }
}