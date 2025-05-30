namespace ConsoleApp
{

    public class Program
    {
        private static LinkedList<ToDoTask> toDoTasks = new LinkedList<ToDoTask>();
        private static LinkedList<ToDoTask> inProgressTasks = new LinkedList<ToDoTask>();
        private static LinkedList<ToDoTask> completedTasks = new LinkedList<ToDoTask>();
        private static int nextTaskId = 1;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome for To-Do App");
            DisplayMenu();
        }

        public static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Add New To-Do Task");
                Console.WriteLine("2. Move Task to In Progress");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. View To-Do Tasks");
                Console.WriteLine("5. View In Progress Tasks");
                Console.WriteLine("6. View Completed Tasks");
                Console.WriteLine("7. Exiting");
                Console.Write("Enter  choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewTask();
                        break;
                    case "2":
                        MoveTaskToInProgress();
                        break;
                    case "3":
                        MoveTaskToComplete();
                        break;
                    case "4":
                        Console.WriteLine("\n--- To-Do Tasks ---");
                        DisplayTasks(toDoTasks);
                        break;
                    case "5":
                        Console.WriteLine("\n--- In Progress Tasks ---");
                        DisplayTasks(inProgressTasks);
                        break;
                    case "6":
                        Console.WriteLine("\n--- Completed Tasks ---");
                        DisplayTasks(completedTasks);
                        break;
                    case "7":
                        Console.WriteLine("Exiting application");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void AddNewTask()
        {
            Console.WriteLine("\n--- Add New Task ---");
            Console.Write("Enter Task Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Task Description: ");
            string description = Console.ReadLine();

            DateTime date;
            while (true)
            {
                Console.Write("Enter Due Date (YYYY-MM-DD): ");
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    break;
