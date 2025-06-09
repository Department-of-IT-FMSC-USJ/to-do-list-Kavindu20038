using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_original
{
    class SinglyLinkList
    {



        public Node head;
        public Node tail;




        public SinglyLinkList()
        {
            head = null;
            tail = null;
        }


        public void inserttask(Node item)
        {
            if (head == null)
            {
                item.next = head;
                head = item;
                return;
            }



            if (head.next == null && item.task.Date < head.task.Date)
            {

                item.next = head;
                head = item;
                return;

            }


            if (head != null && item.task.Date < head.task.Date)

            {
                item.next = head;
                head = item;
                return;
            }

            Node current = head;
            while (current.next != null && current.next.task.Date < item.task.Date)
            {

                current = current.next;

            }
            item.next = current.next;
            current.next = item;
            return;


        }


        public void display()
        {  
            Node? current = head;
            while (current != null)
            {
                Console.WriteLine(current.task);
                current = current.next;

            }
        }


        public void additemtotail(Node item)
        {
            if (head == null)
            {
                item.next = head;
                head = item;
            }

            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                item.next = current.next;
                current.next = item;

            }
        }

        public void removeitemfromhead()
        {
            if (head == null)
            {
                return;
            }

            else
            {
                head = head.next;

            }

        }

        public void additemtohead(Node item)
        {
            if (head == null)
            {
                item.next = head;
                head = item;
                return;
            }
            if (head.next == null)
            {
                item.next = head.next;
                head.next = item;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            item.next = current.next;
        }

        public Node seach(int searchitem)
        {
            if (head == null)
            {
                return null;
            }
            Node current = head;
            while (current != null && current.task.Taskid != searchitem)
            {
                current = current.next;
            }
            return current;



        }

        public void deleteatposition(int seachitem)
        {
            if (head == null)
            {
                return;
            }
            if (head.task.Taskid == seachitem)
            {
                head = head.next;
                return;

            }
            Node current = head;
            while (current.next != null && current.next.task.Taskid != seachitem)
            {
                    current = current.next;

            }


            if (current.next != null)
            {
                    current.next = current.next.next;

            }
               
              







            

        }
    }
}