namespace CloudProjectTracking.Models
{
    using CloudProjectTracking.Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CloudProjectTracking.Models.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Drawing> Drawings { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Project_Manager> Project_Managers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<RFI> RFIs { get; set; }
        public DbSet<Submitals> Submitals { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Status> Status { get; set; } 
  
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Task_Notification> Task_Notifications { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}