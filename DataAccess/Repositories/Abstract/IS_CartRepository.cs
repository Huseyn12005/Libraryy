using Library_Models.Entities.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IS_CartRepository : IGenericRepository<S_Cart>
    {
        ICollection<S_Cart>? GetAllWithStudent();
        ICollection<S_Cart>? GetAllWithBook();
    }
}
