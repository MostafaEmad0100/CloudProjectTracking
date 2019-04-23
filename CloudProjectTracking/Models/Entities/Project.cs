using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Project_Name { get; set; }
        public Contractor Contractor { get; set; }
        public Project_Manager Project_Manger { get; set; }
        public Consultant Consultant { get; set; }
    }
}