using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models
{
    public class ProjectsListViewModel
    {
        public List<ProjectViewModel> Projects { get; }
        public ProjectsListViewModel()
        {
            var db = new ApplicationDbContext();
            string user = Helper.GetCurrentUserId().ToString();
            var projects = db.Projects.Where(m => m.UserId == user).ToList();
            Projects = new List<ProjectViewModel>();
            foreach (var i in projects)
                Projects.Add(new ProjectViewModel(i));
        }
    }
}