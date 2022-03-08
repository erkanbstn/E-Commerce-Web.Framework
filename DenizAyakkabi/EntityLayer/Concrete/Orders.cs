using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public string CardName { get; set; }
        public int UserID { get; set; }
        public virtual Users User { get; set; }
    }
}
