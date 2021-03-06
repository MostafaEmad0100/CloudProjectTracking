﻿using CloudProjectTracking.Models.Entities;
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
        public double BudgetCostWorkSchudling_BCWS { get; set; }
        public double ActualCostofWorkPerformed_ACWP { get; set; }
        public double BudgetCostofWorkPerformed_BCWP { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public DateTime? Actual_Start_Date { get; set; }
        public DateTime? Actual_End_Date { get; set; }
        public Project Project { get; set; }
        public Contractor Contractor { get; set; }
        public IList<Drawing> Drawings { get; set; }
        public IList<RFI> RFIs { get; set; }
        public IList<Report> Reports { get; set; }
        public ICollection<Material> Materials { get; set; }
        public ICollection<Equipments> Equipments { get; set; }
        public ICollection<Task_Documents> Task_Documents { get; set; }
        public IList<Subtasks> Subtasks { get; set; }
        public double Estimated_Duration { get; set; }
        public double PercentageOfCompleteion { get; set; } 
        public double SchudulingIndex_SI { get; set; }
        public double CostIndex_CI { get; set; }
        public double ExpectedFinalDuration { get; set; }
        public double ExpectedFinalCost { get; set; }
        public Task()
        {
            List<Task> tasks = new List<Task>()
            {
                new Task{Name="EarthWorks" ,Id=20},
                new Task {Name="PC-Works" , Id=30 },
                new Task {Name="RC-Works",Id=40}
            };
            Model1 db = new Model1();
            db.Tasks.AddRange(tasks);
            db.SaveChanges();
        }
       

      
    }
}