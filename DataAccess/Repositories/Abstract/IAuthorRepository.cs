using Library_Models.Entities.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        ICollection<Author>? GetAllWithBooks();
    }
}
