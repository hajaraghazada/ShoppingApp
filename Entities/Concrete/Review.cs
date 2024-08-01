using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Review:BaseEntity
    {
        public int ProductID { get; set; }  
        public int UserID { get; set; }  
        public int Rating { get; set; }
        public string Comment { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
