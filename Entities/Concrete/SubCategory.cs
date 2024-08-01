﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class SubCategory:BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Category Category { get; set; } //Lazim olsa IQuaryable ile melumatlari getiririk, lazim deyilse bazada null qalacaq...
    }
}
