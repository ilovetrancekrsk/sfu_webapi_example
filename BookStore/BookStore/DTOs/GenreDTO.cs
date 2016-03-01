using System.Runtime.Serialization;

namespace BookStore.DTOs
{
    [DataContract(Name = "genre")]
    public class GenreDTO
    {
        [DataMember(Name = "id", Order = 0)]
        public int Id { get; set; }

        [DataMember(Name = "title", Order = 1)]
        public string Title { get; set; }

        [DataMember(Name = "description", Order = 2)]
        public string Description { get; set; }
    }
}