using CloudProjectTracking.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public string Material { get; set; }
        public Status Status { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public Project Project { get; set; }
        public Contractor Contractor { get; set; }
        public IList<Drawing> Drawings { get; set; }
        public IList<RFI> RFIs { get; set; }
        public IList<Report> Reports { get; set; }
    }
}