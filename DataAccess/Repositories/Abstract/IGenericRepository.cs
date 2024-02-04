using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(int id);
        T? GetById(int id);
        ICollection<T>? GetAll();
        void Save();
    }
}
