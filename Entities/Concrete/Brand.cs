using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand:BaseEntity
    {
        public int SubCategoryId { get; set; }
        public  string  Name { get; set; }
    }
}
