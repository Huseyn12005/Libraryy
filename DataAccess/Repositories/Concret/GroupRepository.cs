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
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public ICollection<Group>? GetAllWithStudents()
        {
            return _context?.Groups.Include(x => x.Students).ToList();
        }
    }
}
