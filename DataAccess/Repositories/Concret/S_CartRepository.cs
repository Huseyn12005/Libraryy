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
    public class S_CartRepository : GenericRepository<S_Cart>, IS_CartRepository
    {
        public ICollection<S_Cart>? GetAllWithStudent()
        {
            return _context?.S_Carts.Include(x => x.Student).ToList();
        }

        public ICollection<S_Cart>? GetAllWithBook()
        {
            return _context?.S_Carts.Include(x => x.Book).ToList();
        }
    }
}
