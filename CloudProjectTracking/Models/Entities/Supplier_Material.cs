using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Supplier_Material
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public Material Material { get; set; }
    }
}