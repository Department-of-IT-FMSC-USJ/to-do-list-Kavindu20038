using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_original
{
    class Stack
    {
        SinglyLinkList list = new SinglyLinkList();

        public void push(Node node)
        {
            list.additemtohead(node);
        }


        public void pop()
        {
            list.removeitemfromhead();
        }

        public Node peak()
        {
            return list.head;
        }

        public void Display()
        {
            list.display();
        }
    }   

}
