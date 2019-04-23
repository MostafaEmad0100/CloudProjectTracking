using CloudProjectTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.ViewModels
{
    public class ProjectViewModel
    {
        public Project Project { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public Task Task { get; set; }
    }
}