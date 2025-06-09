using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_original
{


    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkList Todolist = new SinglyLinkList();
            Stack Inprogress = new Stack();
            Queue Completed = new Queue();


            while (true)
            {
                Console.WriteLine(">>>>>>>>>>>Welcome to Todo list Application Main menu>>>>>>>>>>>>>>>>>");
                Console.WriteLine("press 1 to insert tasks: ");
                Console.WriteLine("press 2 to view all tasks: ");
                Console.WriteLine("press 3 to move tasks to in progress:  ");
                Console.WriteLine("press 4 to move tasks in to completed: ");
                Console.WriteLine("press 5 to exit: ");



                Console.WriteLine("Enter your selection: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter the Task Name: ");
                        string taskname = Console.ReadLine();

                        Console.WriteLine("Enter the Task ID: ");
                        int taskid = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter the description: ");
                        string description = Console.ReadLine();

                        Console.WriteLine("Enter the date:type as (XXXX-XX-XX):  ");
                        DateOnly date = DateOnly.Parse(Console.ReadLine());

                        Task task = new Task(taskname, taskid, description, date);
                        Node node = new Node(task);
                        Todolist.inserttask(node);

                        break;





                    case "2":
                        Console.WriteLine(">>>>Todolist>>>>");
                        Todolist.display();

                        Console.WriteLine(">>>>inprogress list>>");
                        Inprogress.Display();

                        Console.WriteLine(">>completed list>>");
                        Completed.displayqueue();
                        break;

                    case "3":
                        
                        Console.WriteLine("Enter the task Id to move to Inprogess list: ");
                        int Inprogressid = int.Parse(Console.ReadLine());

                        Node node1 = Todolist.seach(Inprogressid);
                        Todolist.deleteatposition(Inprogressid);
                        node1.task.Status = TaskStatus.InProgress;
                        Inprogress.push(node1);
                        
                        break;

                    case "4":
                        Node node2 = Inprogress.peak();
                        node2.task.Status = TaskStatus.Completed;
                        Inprogress.pop();
                        Completed.Enqueue(node2);

                        break;

                    case "5":
                        Console.WriteLine("Exiting!! Todo list application!");
                        return;
                        break;

                    default:
                        Console.WriteLine("Invalid option!!");
                        break;
 








                }
            }


        }
    }
    
}

