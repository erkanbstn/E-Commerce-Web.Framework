using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string SubCategoryName1 { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Categories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
