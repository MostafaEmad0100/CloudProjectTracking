using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models.Entities
{
    public class Sub_Contractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contractor Contractor { get; set; }
    }
}