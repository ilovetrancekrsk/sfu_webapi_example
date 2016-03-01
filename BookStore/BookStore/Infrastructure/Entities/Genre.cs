using System.ComponentModel.DataAnnotations;
using BookStore.Infrastructure.Entities.Abstract;

namespace BookStore.Infrastructure.Entities
{
    public class Genre : Entity
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}