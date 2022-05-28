using System;
using System.Collections.Generic;
using System.Text;

namespace FreddysDailyPlanner.Models
{
    public class DailyTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsImportant { get; set; }
    }
}
