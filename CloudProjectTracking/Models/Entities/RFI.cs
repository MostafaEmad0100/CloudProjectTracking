using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class RFI
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Task Task { get; set; }
        public Contractor Contractor { get; set; }
        public Consultant Consultant { get; set; }
    }
}