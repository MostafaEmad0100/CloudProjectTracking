using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models.Entities
{
    public class Tasks_Matrial
    {
        [Key,Column(Order = 1)]
        public int FK_Task { get; set; }
        [Key, Column(Order = 2)]
        public int FK_Material { get; set; }
    }
}