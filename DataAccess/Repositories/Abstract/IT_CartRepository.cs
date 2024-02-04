using Library_Models.Entities.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IT_CartRepository : IGenericRepository<T_Cart>
    {
        ICollection<T_Cart>? GetAllWithTeacher();
        ICollection<T_Cart>? GetAllWithBook();
    }
}
