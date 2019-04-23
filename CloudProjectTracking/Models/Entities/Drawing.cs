using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Drawing
    {
        public int Id { get; set; }
        public string Drwaing_Name { get; set; }
        public Consultant Consultant { get; set; }
        public Task Task { get; set; }
    }
}