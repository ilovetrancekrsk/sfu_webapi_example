using System.Linq;
using System.Web.Http;
using BookStore.DTOs;
using BookStore.Infrastructure;

namespace BookStore.Controllers
{
    [RoutePrefix("api/genres")]
    public class GenresController : ApiController
    {
        private readonly BookStoreContext _bsContext = new BookStoreContext();

        // GET api/genres
        public IQueryable<GenreDTO> Get()
        {
            return _bsContext.Genres.Select(g => new GenreDTO
            {
                Id = g.Id,
                Title = g.Title,
                Description = g.Description
            });
        }

        // GET api/genres/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/genres
        public void Post([FromBody]string value)
        {
        }

        // PUT api/genres/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/genres/5
        public void Delete(int id)
        {
        }
    }
}
