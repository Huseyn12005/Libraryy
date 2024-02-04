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
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public ICollection<Author>? GetAllWithBooks()
        {
            return _context?.Authors.Include(x => x.Books).ToList();
        }
    }
}
