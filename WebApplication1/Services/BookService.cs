using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepo;
        public BookService(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }
        public Book GetById(int id)
        {
            if (id == 0000)
            {
                return null;
            }
            return _bookRepo.GetById(id);
        }
    }
}
