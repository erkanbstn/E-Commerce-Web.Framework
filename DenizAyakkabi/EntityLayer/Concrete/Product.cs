﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public double Price{ get; set; }
        public int Quantity{ get; set; }
        public string Image{ get; set; }
        public int SubCategoryID { get; set; }
        public virtual SubCategory SubCategory{ get; set; }
    }
}
