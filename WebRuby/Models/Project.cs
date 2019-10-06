using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public DateTime Deadline { get; set; }
    }
}