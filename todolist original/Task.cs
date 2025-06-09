using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_original
{
    
    
        public enum TaskStatus
        {
            ToDo,
            InProgress,
            Completed
        }

        class Task
        {
            private string taskname;
            private int taskid;
            private string description;
            private DateOnly date;
            private TaskStatus status;

            public string Taskname { get => taskname; set => taskname = value; }
            public int Taskid { get => taskid; set => taskid = value; }
            public string Description { get => description; set => description = value; }
            public DateOnly Date { get => date; set => date = value; }
            public TaskStatus Status { get => status; set => status = value; }


            public Task(string taskname, int taskid, string description, DateOnly date)
            {
                this.Taskname = taskname;
                this.Taskid = taskid;
                this.Description = description;
                this.Date = date;
                this.Status = TaskStatus.ToDo;

            }

            public override string? ToString()
            {
                return $"Task : {Taskname}, Task Id : {Taskid}, due at : {Date}, Status : {Status}";
            }
        }
    

}

