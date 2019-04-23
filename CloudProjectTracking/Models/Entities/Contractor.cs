using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Contractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Submitals> Submitals { get; set; }
        public IList<Project> Projects { get; set; }
        public IList<Task> Tasks { get; set; }
        public IList<RFI> RFIs { get; set; }
    }
}