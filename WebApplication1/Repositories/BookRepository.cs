using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book GetById(int id)
        {
            return new Book
            {
                Id = 1,
                Author = "Pham Ngoc Nhat",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam",
                Price = 75000,
                Title = "Nang ha",
                PublishDate = DateTime.Now,
            };
        }
    }
}
