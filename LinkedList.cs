using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNQueueDataStructure
{
    public class LinkedList
    {
        public Node head;


        //Method to add element to the last
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null) //if linked list is empty
            {
                head = newNode;
                Console.WriteLine("{0} is added", data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
                Console.WriteLine("{0} is added", data);
            }
        }

        //Method to get the Last Node
        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp; //returning last node
        }

        //add element at first place
        public void AddFirst(int data)
        {
            Node newNode = new Node(data); //created new node to add
            newNode.next = head; //stored address of head node to the new node
            head = newNode; //assiging new node to head
            Console.WriteLine("{0} is added as a first element", data);
        }

        //display elements in LinkedList
        public void Display()
        {
            Console.WriteLine("Nodes Elements in Linked List : ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
                return; //control returned to main method from where it came
            }
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }

        }

        //append element
        public void Append(int data)
        {
            AddLast(data); //functionality is same as AddLast so calling the method here
        }

        //insert in between or at position
        public void InsertElementInBetweenOrAtPosition(int position, int data)
        {

            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.next;
                }
                if (temp != null)
                {
                    Node newNode = new Node(data);
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
            Console.WriteLine("{0} is inserted at {1} position", data, position);
        }

        //delete first element
        public void DeleteFirst()
        {
            if (head == null)
                Console.WriteLine("LinkedList is Empty!!");
            else
            {
                int elementRemoved = head.data;
                head = head.next;
                Console.WriteLine("First node element {0} is deleted from the Linked List", +elementRemoved);
            }
        }

        //delete last element      
        public void DeleteLast()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("LinkedList is Empty!!");
            if (temp.next == null)//True only if we have only one node or second node null
            {
                int data = temp.data;
                temp = null;
                Console.WriteLine("Node element {0} is deleted ", data);
            }
            else
            {
                while (temp.next.next != null)//if we have more than one node element or second node is not equal to null
                {
                    temp = temp.next;
                }
                int lastDeleteNode = temp.next.data;
                temp.next = null;
                Console.WriteLine("Last node element {0} is deleted ", lastDeleteNode);
            }
        }

        //search with value
        public void SearchElement(int searchElement)
        {
            int node = 1;
            int elementfound = 0;
            if (head == null)
                Console.WriteLine("Linked list is empty!!");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == searchElement)
                    {
                        Console.WriteLine("Element {0} found at Node {1}", searchElement, node);
                        elementfound = 1;
                    }
                    temp = temp.next;
                    node++;
                }
                if (elementfound == 0)
                    Console.WriteLine("Element {0} is not present in the Linked List", searchElement);
            }

        }

        //insert after element
        public void InsertDataAfterELement(int data, int element)
        {
            int elementfound = 0;

            Node newElement = new Node(data);

            if (head == null)
                Console.WriteLine("Linked list is empty!!");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == element)
                    {
                        Node tempAdd = temp.next; //storing temp address to add it to newElement.next
                        temp.next = newElement;
                        newElement.next = tempAdd;
                        elementfound = 1;
                        Console.WriteLine("{0} is inserted after {1}", data, element);
                        break;
                    }
                    temp = temp.next;
                }
                if (elementfound == 0)
                    Console.WriteLine("Element {0} is not present in the Linked List", element);
            }
        }

        //Search for Node element and Delete
        public void SearchElementNDelete(int searchElement)
        {
            int node = 1;
            int elementfound = 0;
            if (head == null)
                Console.WriteLine("Linked list is empty!!");
            if (head.data == searchElement)
            {
                elementfound = 1;
                head = head.next;
                Console.WriteLine("Element {0} found at Node {1}", searchElement, node);
                Console.WriteLine("Element {0} deleted", searchElement);
            }
            else
            {
                Node currentNode = head;
                Node previousNode = head;
                while (currentNode != null)
                {
                    if (currentNode.data == searchElement)
                    {
                        Console.WriteLine("Element {0} found at Node {1}", searchElement, node);

                        for (int i = 1; i < node - 1; i++)
                        {
                            previousNode = previousNode.next;
                        }
                        previousNode.next = currentNode.next;
                        Console.WriteLine("Element {0} deleted", searchElement);
                        currentNode.next = null;

                        elementfound = 1;
                    }
                    currentNode = currentNode.next;
                    node++;
                }
                if (elementfound == 0)
                    Console.WriteLine("Element {0} is not present in the Linked List", searchElement);
            }

        }

        //size
        public void Size()
        {
            int size = 1;

            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
                return; //control returned to main method from where it came
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                    size++;
                }
                Console.WriteLine("Size of the Linked List is " + size);
            }

        }

    }
}
