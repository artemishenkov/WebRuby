using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models
{
    public class TaskViewModel
    {
        public Task Task { get; }

        public TaskViewModel(Task task)
        {
            Task = task;           
        }
    }
}