using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNQueueDataStructure
{
    internal class Stack
    {
        public Node top;
        LinkedList linkedlistObj = new LinkedList();

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if(this.top != null)
            {
                newNode.next = this.top; 
            }
            this.top = newNode;
            Console.WriteLine("{0} is added", data);
        }
        
        public void Display()
        {
            Node tempTop = top;
            if(this.top == null)
                Console.WriteLine("Stack is empty!!");

            while(tempTop != null)
            {
                Console.WriteLine("Element in stack : " + tempTop.data);
                tempTop = tempTop.next;
            }

        }

    }
}
