using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int BrandID { get; set; }  
        public int ColorID { get; set; }
        public int SubCategoryID { get; set; }
        public  string Capacity { get; set; }
        public string ImageURL { get; set; }
        public bool IsDiscount {  get; set; }
        public decimal DiscountRate { get; set; }

        public Delivery DeliveryType { get; set; }
        public List<Review> Reviews { get; set; }  
        public Brand Brand { get; set; }//Lazim olsa IQuaryable ile melumatlari getiririk, lazim deyilse bazada null qalacaq...
        public ICollection<Color> Colors { get; set; } = new HashSet<Color>();
        public SubCategory SubCategory { get; set; }
        

    }
}
