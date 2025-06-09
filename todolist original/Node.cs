using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_original
{
    
    
        class Node
        {
            public Task task;
            public Node next;

            public Node(Task task)
            {
                this.task = task;
                this.next = null;

            }
        }
    
}
