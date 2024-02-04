using DataAccess.Repositories.Abstract;
using Library_Models.Entities.Concret;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concret
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public ICollection<Category>? GetAllWithBooks()
        {
            return _context?.Categories.Include(x => x.Books).ToList();
        }

        public ICollection<Category>? GetAll(Expression<Func<Category, bool>> expression)
        {
            return _context?.Categories.Where(expression).ToList();
        }
    }
}
