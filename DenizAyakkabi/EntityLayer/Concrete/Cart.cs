using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public virtual int UserID { get; set; }
        public virtual Users Users { get; set; }
        public virtual int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price{ get; set; }
        public DateTime AddedDate { get; set; }
    }
}
