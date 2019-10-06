using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models
{
    public class TaskBoardViewModel
    {
        public List<Project> Projects { get; set; }
        public AddProjectViewModel AddProjectModel { get; set; }
    }
}