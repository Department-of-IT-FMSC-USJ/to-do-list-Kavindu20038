using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_original
{
    class Queue
    {
        SinglyLinkList list = new SinglyLinkList();

        public void Enqueue(Node node)
        {
            list.additemtotail(node);
        }


        public void dequeue()
        {
            list.removeitemfromhead();
        }


        public Node Peak()
        {
            return list.head;
        }
        

        public void displayqueue()
        {
            list.display();
        }

            


    }
}
