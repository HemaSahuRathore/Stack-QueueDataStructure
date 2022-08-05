using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNQueueDataStructure
{
    internal class Queue
    {
        public Node head;

        //Enqueue : insert element
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node tempHead = this.head;
                while(tempHead.next != null)
                {
                    tempHead = tempHead.next;
                }
                tempHead.next = newNode;
            }
            Console.WriteLine("{0} is Added to Queue", data);
        }

        //Display
        public void Display()
        {
            Node tempHead = this.head;
            if(head == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            else
            {
                while (tempHead != null)
                {
                    Console.Write(tempHead.data + " ");
                    tempHead = tempHead.next;
                }

            }
        }
    }
}
