using System;

namespace Voyon.DotNet.Interview.Logic.Models
{
    public class TaskViewModel
    {
        public string Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; }

        public UserViewModel AssignedUser { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}