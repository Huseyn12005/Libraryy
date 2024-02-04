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
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public ICollection<Teacher>? GetAllWithT_Carts()
        {
            return _context?.Teachers.Include(x => x.T_Carts).ToList();
        }
    }
}
