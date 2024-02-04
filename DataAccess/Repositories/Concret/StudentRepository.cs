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
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public ICollection<Student>? GetAllWithGroup()
        {
            return _context?.Students.Include(x => x.Group).ToList();
        }

        public ICollection<Student>? GetAllWithS_Carts()
        {
            return _context?.Students.Include(x => x.S_Carts).ToList();
        }
    }
}
