using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Infrastructure.Entities.Abstract;

namespace BookStore.Infrastructure.Entities
{
    public class Author : Entity
    {
        [Required]
        public string FullName { get; set; }

        public DateTime Birthday { get; set; }

        public virtual ICollection<Book> Books { get; set; } 
    }
}