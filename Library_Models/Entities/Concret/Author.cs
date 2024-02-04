using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Models.Entities.Concret
{
    public class Author : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        //Navigation Property
        public virtual ICollection<Book>? Books { get; set; }
    }
}
