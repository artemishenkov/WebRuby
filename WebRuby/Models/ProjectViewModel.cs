using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebRuby.Models.Tags;

namespace WebRuby.Models
{
    public class ProjectViewModel
    {
        public Project Project { get; }
        public TasksListViewModel Tasks { get; }
        public Button AddTaskBtn { get; }
        public Input AddTaskInput { get; set; }
        public ProjectViewModel(Project project)
        {
            var db = new ApplicationDbContext();
            Project = project;
            Tasks = new TasksListViewModel(Project.Id);
            AddTaskBtn = new Button("Add task", new Dictionary<string, string>
            {
                { "class", "btn btn-success add-task-btn" },
            });
            AddTaskInput = new Input(new Dictionary<string, string>
            {
                { "class", "form-control add-task-input" },
                { "placeholder", "Start typing here to create a task..." },
            });
        }
    }
}