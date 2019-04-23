using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Submitals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contractor Contractor { get; set; }
        public Consultant Consultant { get; set; }
    }
}