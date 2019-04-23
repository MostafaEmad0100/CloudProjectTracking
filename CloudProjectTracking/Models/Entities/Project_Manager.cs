using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models
{
    public class Project_Manager
    {
        public int Id { get; set; }
        public string ProjectManger_Name { get; set; }

        public IList<Project> Projects { get; set; }
    }
}