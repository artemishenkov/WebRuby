using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public bool Status { get; set; }
        public int Priority { get; set; }
    }
}