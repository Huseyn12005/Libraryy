using DataAccess.Repositories.Abstract;
using Library_Models.Entities.Concret;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concret
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public ICollection<Book>? GetAllWithCaregory()
        {
            return _context?.Books.Include(x => x.Category).ToList();
        }

        public ICollection<Book>? GetAllWithAuthors()
        {
            return _context?.Books.Include(x => x.Authors).ToList();
        }

    }
}
