using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Project> Projects { get; set; }
        public IList<Report> Reports { get; set; }
        public IList<Drawing> Drawings { get; set; }
        public IList<RFI> RFIs { get; set; }
        public IList<Submitals> Submitals { get; set; }
    }
}