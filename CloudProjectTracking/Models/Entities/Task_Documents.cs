using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudProjectTracking.Models.Entities
{
    public class Task_Documents
    {
        public int Id { get; set; }
        public string Document_Name { get; set; }
        public byte[] Data { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Task Task { get; set; }
    }
}