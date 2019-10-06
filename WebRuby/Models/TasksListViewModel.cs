using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models
{
    public class TasksListViewModel
    {
        public List<TaskViewModel> Tasks { get; }
        public TasksListViewModel(int projectId)
        {
            var db = new ApplicationDbContext();
            Tasks = new List<TaskViewModel>();
            string user = Helper.GetCurrentUserId().ToString();
            var tasks = db.Tasks.Where(m => m.ProjectId == projectId).ToList().OrderByDescending(m => m.Priority);
            foreach (var i in tasks)
                Tasks.Add(new TaskViewModel(i));
        }

    }
}