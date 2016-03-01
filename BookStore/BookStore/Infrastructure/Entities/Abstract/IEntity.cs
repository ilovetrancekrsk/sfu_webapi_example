using System;

namespace BookStore.Infrastructure.Entities.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime ModifiedAt { get; set; }
    }
}
