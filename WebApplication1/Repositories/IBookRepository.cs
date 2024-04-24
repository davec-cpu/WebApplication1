using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IBookRepository
    {
        Book GetById(int id);
    }
}
