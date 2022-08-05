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

        //add data
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
        
        //display element
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

        //display top most data
        public void peek() 
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty!! No elemt is present.");
                return;
            }               
            else
                Console.WriteLine("The top most element in stack is " + this.top.data);
        }

        //remove top most element
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty!! No element is present");
                return;
            }
            else
            {
                int deleteNode = top.data;
                this.top = top.next; //assiging top to next element
                Console.WriteLine("{0} is deleted from the top", deleteNode);
            }
        }

        //return true if stack is empty else false
        public bool IsEmpty()
        {
            while(this.top != null)
            {
                peek();
                Pop();
            }
            return true;
        }
        
       

    }
}
