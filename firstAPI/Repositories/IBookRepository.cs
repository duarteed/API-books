using firstAPI.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int Id);

        Task<Book> Create(Book book);

        Task Update(Book book);

        Task Delete(int Id);
    }
}
