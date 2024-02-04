using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Models.Entities.Concret
{
    public class Group:BaseEntity
    {
        public string? Name { get; set; }

        //Navigation property
        public virtual ICollection<Student> Students { get; set; }
    }
}
