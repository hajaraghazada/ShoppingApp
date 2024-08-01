using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set;}=new HashSet<Product>();
    }
}
