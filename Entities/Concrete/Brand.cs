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
        public string Name { get; set; }
        public List<Product> Products { get; set; }
       
    }
}
