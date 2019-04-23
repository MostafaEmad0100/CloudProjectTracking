using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Material> Materials { get; set; }
    }
}