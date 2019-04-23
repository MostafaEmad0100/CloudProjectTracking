using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Contractor Contractor { get; set; }
        public Material Material { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime? Order_Date { get; set; }
        public float Cost { get; set; }
        public int Quantity { get; set; }
    }
}