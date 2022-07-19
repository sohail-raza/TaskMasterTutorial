using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMasterTutorial.Model
{
    public class Task
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; } //? makes it nullable

        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
