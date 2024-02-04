using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Models.Entities.Concret
{
    public class Teacher:BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //Navigation property
        public virtual ICollection<T_Cart> T_Carts { get; set; }
    }
}
