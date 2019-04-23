using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Supplier> Suppliers { get; set; }
    }
}