using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models.Entities
{
    public class Equipments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Task Task { get; set; }
    }
}