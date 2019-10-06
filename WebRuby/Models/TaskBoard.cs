using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebRuby.Models.Tags;

namespace WebRuby.Models
{
    public class TaskBoard
    {
        public ProjectsListViewModel ProjectsList { get; }
        public Button AddProjectBtn { get; }
        public AddProjectViewModel AddProjectModel { get; }
        public TaskBoard()
        {
            var db = new ApplicationDbContext();
            string user = Helper.GetCurrentUserId().ToString();
            var projects = db.Projects.Where(m => m.UserId == user).ToList();
            ProjectsList = new ProjectsListViewModel();          
            string innerHtml = "" +
            "<i class=\"fas fa-plus add-project-plus\"></i>" +
            "<span> Add TODO List</span>";
            AddProjectBtn = new Button(innerHtml, new Dictionary<string, string> {
                { "class", "btn-lg btn-primary" },
                { "id", "add-project-btn" }
            });
            AddProjectModel = new AddProjectViewModel();
                
        }
    }
}