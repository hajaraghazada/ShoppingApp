using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Review
    {
        public int ProductID { get; set; }  // Foreign Key
        public int UserID { get; set; }  // Foreign Key
        public int Rating { get; set; }
        public string Comment { get; set; } 
    }
}
