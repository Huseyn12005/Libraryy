using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Models.Entities.Concret
{
    public class Book:BaseEntity
    {
        public string? Name { get; set; }
        public int Pages { get; set; }

        // Foreign Key
        public int? CategoryId { get; set; }

        //Navigation Property
        public virtual ICollection<Author>? Authors { get; set; } 
        public virtual Category? Category { get; set; }
        public virtual ICollection<S_Cart> S_Carts { get; set; }
        public virtual ICollection<T_Cart> T_Carts { get; set; }
    }
}
