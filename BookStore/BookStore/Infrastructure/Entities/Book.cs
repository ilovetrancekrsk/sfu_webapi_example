using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Infrastructure.Entities.Abstract;

namespace BookStore.Infrastructure.Entities
{
    public class Book : Entity
    {
        [Required]
        public string Name { get; set; }

        public string Annotation { get; set; }

        public DateTime PublishedAt { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        
        public virtual ICollection<Genre> Genres { get; set; } 
    }
}