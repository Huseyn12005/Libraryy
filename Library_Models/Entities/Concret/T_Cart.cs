using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Models.Entities.Concret
{
    public class T_Cart:BaseEntity
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        // Foreign Key
        public int? TeacherId { get; set; }
        public int? BookId { get; set; }

        //Navigation property
        public virtual Book Book { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
