using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models.Entities
{
    public class Subtasks
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
        public double Estimated_Duration { get; set; }
        public double PercentageOfCompleteion { get; set; }
        public double SchudulingIndex_SI { get; set; }
        public double CostIndex_CI { get; set; }
        public double ExpectedFinalDuration { get; set; }
        public double ExpectedFinalCost { get; set; }
        public Task Task { get; set; }
        public int FK_Task { get; set; }
        public Subtasks()
        {
            var contractor = new Contractor()
            {
                Id = 10,
                Name = "Arab Cntractor"
            };
            List<Subtasks> subtasks = new List<Subtasks>()
           {
               new Subtasks{Name="Excavation" , FK_Task=10 ,
                   Start_Date = new DateTime(2019,1,1),
                   End_Date =new DateTime(2019,1,10),BudgetCostWorkSchudling_BCWS=37500,
                   Contractor=contractor,

                   


               },

               
           };
        }
    }
}