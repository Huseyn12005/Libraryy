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
    public class T_CartRepository : GenericRepository<T_Cart>, IT_CartRepository
    {
        public ICollection<T_Cart>? GetAllWithTeacher()
        {
            return _context?.T_Carts.Include(x => x.Teacher).ToList();
        }

        public ICollection<T_Cart>? GetAllWithBook()
        {
            return _context?.T_Carts.Include(x => x.Book).ToList();
        }
    }
}
