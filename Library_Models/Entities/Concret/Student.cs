using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Models.Entities.Concret
{
    public class Student: BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}

        // Foreign Key
        public int? GroupId { get; set; }


        //Navigation property
        public virtual Group Group { get; set; }
        public virtual ICollection<S_Cart> S_Carts { get; set; }
    }
}
